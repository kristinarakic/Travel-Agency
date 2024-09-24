using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel;
using System.Xml.Linq;

namespace ProjekatTVP
{
    [Serializable]
    public class User
    {
        private int ID;
        private string Name;
        private string Surname;
        private string Username;
        private string Password;
        private string UserType;

        public User(int iD, string name, string surname, string username, string password, string userType)
        {
            ID = iD;
            Name = name;
            Surname = surname;
            Username = username;
            Password = password;
            UserType = userType;
        }

        public User()
        {
            ID = 0;
            Name = "";
            Surname = "";
            Username = "";
            Password = "";
            UserType = "";
        }

        public int ID1 { get => ID; set => ID = value; }
        public string Name1 { get => Name; set => Name = value; }
        public string Surname1 { get => Surname; set => Surname = value; }
        public string Username1 { get => Username; set => Username = value; }
        public string Password1 { get => Password; set => Password = value; }
        public string UserType1 { get => UserType; set => UserType = value; }

        public override string? ToString()
        {
            return "ID: " + ID + 
                ", Ime: " + Name + 
                ", Prezime: " + Surname +
                ", Korisničko ime: " + Username + 
                ", Lozinka: " + Password;
        }
    }
}
