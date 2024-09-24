using System;
using System.Collections.Generic;
using System.Configuration;
using System.Diagnostics.Metrics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml;
using Microsoft.VisualBasic.ApplicationServices;
using Newtonsoft.Json;
using Formatting = Newtonsoft.Json.Formatting;

namespace ProjekatTVP
{

    public class UserManager
    {

        private List<User> users;
        private List<User> admins;
        private static int clientsID;

        public static int ClientsID { get => clientsID; set => clientsID = value; }

        public UserManager()
        {
            admins = LoadUsers("admins.json");
            users = LoadUsers("clients.json");
        }

        public int GetNextUserID()
        {
            List<User> allUsers = new List<User>(this.users);
            allUsers.AddRange(admins);

            int nextID = 1;

            allUsers.Sort((a, b) => a.ID1.CompareTo(b.ID1));

            for (int i = 0; i < allUsers.Count; i++)
            {
                if (allUsers[i].ID1 == nextID)
                    nextID++;
                else if (allUsers[i].ID1 > nextID)
                    return nextID;
            }

            return nextID;
        }
        public static bool AuthenticateUser(string username, string password, string userType, out User? user)
        {
            List<User> admins = LoadUsers("admins.json");
            List<User> clients = LoadUsers("clients.json");
            user = null;
            if (userType == "Admin")
            {
                if (!admins.Any())
                {
                    MessageBox.Show("Ne postoji nijedan admin.", "Greška", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return false;
                }

                user = admins.FirstOrDefault(u => u.Username1 == username && u.Password1 == password);
            }
            else
            {
                if (!clients.Any())
                {
                    MessageBox.Show("Ne postoji nijedan korisnik.", "Greška", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return false;
                }

                user = clients.FirstOrDefault(u => u.Username1 == username && u.Password1 == password);
            }

            if (user == null)
            {
                MessageBox.Show("Uneti pogrešni podaci.", "Greška", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
            clientsID = user.ID1;
            return true;
        }
        public bool RegisterUser(string name, string surname, string username, string password, string userType)
        {
            if (users.Any(u => u.Username1 == username))
            {
                MessageBox.Show("Korisnik sa unetim korisničkim imenom već postoji.", "Greška", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }

            users.Add(new User(GetNextUserID(), name, surname, username, password, "klijent"));
            SaveUsers("clients.json", users);
            MessageBox.Show("Uspešna registracija!", "Informacija", MessageBoxButtons.OK, MessageBoxIcon.Information);
            return true;
        }
      
        //CRUD
        public bool AddUser(string name, string surname, string username, string password, string userType)
        {
            string fileName = "";

            if (userType == "Admin")
            {
                fileName = "admins.json";
            }
            else if (userType == "Klijent")
            {
                fileName = "clients.json";
            }

            List<User> targetList = fileName == "admins.json" ? admins = LoadUsers(fileName) : users = LoadUsers(fileName);

            if (targetList.Any(u => u.Username1 == username))
            {
                MessageBox.Show($"{userType} sa unetim korisničkim imenom već postoji.");
                return false;
            }

            targetList.Add(new User(GetNextUserID(), name, surname, username, password, userType));
            MessageBox.Show("Uspešno dodavanje korisnika", "Informacija", MessageBoxButtons.OK, MessageBoxIcon.Information);
            SaveUsers(fileName, targetList);
            return true;
        }
        public bool AlterUser(User updatedUser, string currentUserType)
        {
            List<User> currentList = currentUserType.Equals("Admin", StringComparison.OrdinalIgnoreCase) ? admins : users;
            List<User> otherList = currentUserType.Equals("Admin", StringComparison.OrdinalIgnoreCase) ? users : admins;
            string currentFileName = currentUserType.Equals("Admin", StringComparison.OrdinalIgnoreCase) ? "admins.json" : "clients.json";
            string otherFileName = currentUserType.Equals("Admin", StringComparison.OrdinalIgnoreCase) ? "clients.json" : "admins.json";

            var userToUpdate = currentList.FirstOrDefault(u => u.ID1 == updatedUser.ID1);

            if (currentList.Concat(otherList).Any(u => u.Username1.Equals(updatedUser.Username1) && u.ID1 != updatedUser.ID1))
            {
                MessageBox.Show("Korisničko ime već postoji.", "Upozorenje", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }
            if (userToUpdate != null)
            {
                userToUpdate.Name1 = updatedUser.Name1;
                userToUpdate.Surname1 = updatedUser.Surname1;
                userToUpdate.Username1 = updatedUser.Username1;
                userToUpdate.Password1 = updatedUser.Password1;
                userToUpdate.UserType1 = updatedUser.UserType1;
            }
            else
            {
                MessageBox.Show("Nije pronađen korisnik za izmenu.", "Greška", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }

            if (!currentUserType.Equals(updatedUser.UserType1, StringComparison.OrdinalIgnoreCase))
            {
                currentList.Remove(userToUpdate);
                otherList.Add(userToUpdate);

                return SaveUserLists(currentFileName, currentList, otherFileName, otherList);
            }
            else
            {
                return SaveUserLists(currentFileName, currentList);
            }
        }

        private bool SaveUserLists(string currentFileName, List<User> currentList, string? otherFileName = null, List<User>? otherList = null)
        {
            SaveUsers(currentFileName, currentList);
            if (otherFileName != null && otherList != null)
                SaveUsers(otherFileName, otherList);

            MessageBox.Show("Korisnik je uspešno izmenjen.", "Informacija", MessageBoxButtons.OK, MessageBoxIcon.Information);
            return true;

        }
        public bool DeleteUser(int userID, string userType)
        {
            List<User> users = new List<User>();
            string fileName = "";

            if (userType == "Admin")
            {
                users = admins;
                fileName = "admins.json";
            }
            else if (userType == "Klijent")
            {
                users = this.users;
                fileName = "clients.json";
            }

            User? foundUserToDelete = users.FirstOrDefault(u => u.ID1 == userID);

            if (foundUserToDelete == null)
            {
                MessageBox.Show("Korisnik sa navedenim ID-om ne postoji.", "Greška", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }

            if (ReservationManager.LoadReservations().Any(r => r.UserID1 == userID))
            {
                MessageBox.Show("Korisnik ima rezervacije i ne može biti obrisan.", "Upozorenje", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }

            users.Remove(foundUserToDelete);
            SaveUsers(fileName, users);
            MessageBox.Show("Uspešno brisanje korisnika.", "Informacija", MessageBoxButtons.OK, MessageBoxIcon.Information);
            return true;
        }
        public static void UsersPrinter(string userType, ListView listView1)
        {
            listView1.Items.Clear();
            listView1.Columns.Clear();

            listView1.View = View.Details;
            listView1.Columns.Add("ID", 40, HorizontalAlignment.Left);
            listView1.Columns.Add("Ime", 80, HorizontalAlignment.Left);
            listView1.Columns.Add("Prezime", 80, HorizontalAlignment.Left);
            listView1.Columns.Add("Korisničko ime", 115, HorizontalAlignment.Left);
            listView1.Columns.Add("Lozinka", 80, HorizontalAlignment.Left);

            string fileName = userType.Equals("Admin") ? "admins.json" : "clients.json";

            foreach (User user in UserManager.LoadUsers(fileName))
            {
                var item = new ListViewItem(user.ID1.ToString());
                item.SubItems.Add(user.Name1);
                item.SubItems.Add(user.Surname1);
                item.SubItems.Add(user.Username1);
                item.SubItems.Add(user.Password1);
                listView1.Items.Add(item);

                item.Tag = user;
            }


        }
        public static List<User> LoadUsers(string fileName)
        {
            List<User> users = new List<User>();
            if (File.Exists(fileName))
            {
                try
                {
                    string json = File.ReadAllText(fileName);
                    var deserializedUsers = JsonConvert.DeserializeObject<List<User>>(json);
                    if (deserializedUsers != null)
                        return deserializedUsers;
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"Došlo je do greške prilikom čitanja: {ex.Message}");
                    users = new List<User>();
                }
            }
            else
            {
                MessageBox.Show("Fajl upis korisnika ne postoji.");
                users = new List<User>();
            }
            return users;
        }
        public static void SaveUsers(string fileName, List<User> users)
        {
            try
            {
                string json = JsonConvert.SerializeObject(users, Formatting.Indented);

                File.WriteAllText(fileName, json);

            } 
            catch (Exception ex)
            {
                MessageBox.Show($"Došlo je do greške prilikom upisa u fajl: {ex.Message}");
            }
        }

    }
}


