using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Reflection.Emit;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel;
using System.Xml.Linq;

namespace ProjekatTVP
{
    public partial class AlterUser : Form
    {
        AdminForm AdminForm;
        UserManager userManager;
        string userType;

        public AlterUser(AdminForm adminForm)
        {
            InitializeComponent();
            AdminForm = adminForm;
            userManager = new UserManager();
            userType = "";

            rbAdmins.CheckedChanged += CheckedChanged;
            rbClients.CheckedChanged += CheckedChanged;
        }

        // Added
        private void CheckedChanged(object? sender, EventArgs e)
        {
            if (rbAdmins.Checked)
            {
                UserManager.UsersPrinter("Admin", listView1);
                userType = "Admin";
                lblListViewCaption.Text = "Prikaz admina:";
            }
            else if (rbClients.Checked)
            {
                UserManager.UsersPrinter("Klijent", listView1);
                userType = "Klijent";
                lblListViewCaption.Text = "Prikaz korisnika:";
            }
        }
        private void TextBoxCleaner()
        {
            txtName.Text = "";
            txtPassword.Text = "";
            txtSurname.Text = "";
            txtUsername.Text = "";
            txtUserType.Text = "";
        }


        // OnClick
        private void btnAlterUser_Click(object sender, EventArgs e)
        {
            if (listView1.Items.Count < 1)
            {
                MessageBox.Show("Morate izabrati korisnika za izmenu.", "Greška", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            else if (string.IsNullOrEmpty(txtName.Text) || string.IsNullOrEmpty(txtPassword.Text)
                || string.IsNullOrEmpty(txtSurname.Text) || string.IsNullOrEmpty(txtUsername.Text))
            {
                MessageBox.Show("Morate popuniti sva polja.", "Greška", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            else
            {
                User? userToUpdate = (User)listView1.SelectedItems[0].Tag;

                if (userToUpdate != null)
                {
                    userToUpdate.Name1 = txtName.Text;
                    userToUpdate.Surname1 = txtSurname.Text;
                    userToUpdate.Username1 = txtUsername.Text;
                    userToUpdate.Password1 = txtPassword.Text;
                    userToUpdate.UserType1 = txtUserType.Text;

                    userManager.AlterUser(userToUpdate, userType);
                }
            }
            UserManager.UsersPrinter(userType, listView1);
            TextBoxCleaner();
        }
        private void btnDeleteUser_Click(object sender, EventArgs e)
        {
           
            if (listView1.SelectedItems.Count > 0)
            {
                User userToDelete = (User)listView1.SelectedItems[0].Tag;

                userManager.DeleteUser(userToDelete.ID1, userType);
            }
            else
            {
                MessageBox.Show("Morate izabrati korisnika za brisanje.", "Greška", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            UserManager.UsersPrinter(userType, listView1);
            TextBoxCleaner();
        }
        private void btnCreateUser_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtName.Text) || string.IsNullOrEmpty(txtSurname.Text)
                || string.IsNullOrEmpty(txtUsername.Text) || string.IsNullOrEmpty(txtPassword.Text))
            {
                MessageBox.Show("Morate popuniti sva polja.", "Greška", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            else
            {
                userManager.AddUser(txtName.Text, txtSurname.Text, txtUsername.Text, txtPassword.Text, txtUserType.Text);

                UserManager.UsersPrinter(userType, listView1);
                TextBoxCleaner();
            }
           
        }
        private void panel2_MouseClick(object sender, MouseEventArgs e)
        {
            AdminForm.Show();
            this.Close();
        }

        // Other
        private void listView1_ItemActivate(object? sender, EventArgs e)
        {
            if (listView1.SelectedItems.Count > 0)
            {
                    ListViewItem selectedItem = listView1.SelectedItems[0];

                    if (int.TryParse(selectedItem.Text, out int selectedId))
                    {
                        string fileName = userType == "Admin" ? "admins.json" : "clients.json";

                        User? selectedUser = UserManager.LoadUsers(fileName)
                                                      .FirstOrDefault(u => u.ID1 == selectedId);

                        if (selectedUser != null)
                        {
                            txtName.Text = selectedUser.Name1;
                            txtSurname.Text = selectedUser.Surname1;
                            txtUsername.Text = selectedUser.Username1;
                            txtPassword.Text = selectedUser.Password1;
                            txtUserType.Text = selectedUser.UserType1;
                        }
                        else
                        {
                            MessageBox.Show("Korisnik nije pronađen.", "Greška", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                    }
                    else
                    {
                        MessageBox.Show("ID korisnika nije validan.", "Greška", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
            }
        }
        private void AlterKorisnik_Load(object sender, EventArgs e)
        {
            cmbOption.SelectedIndex = 0;
            rbAdmins.Checked = true;
        }
        private void cmbOption_SelectedIndexChanged(object sender, EventArgs e)
        {
            btnCreateUser.Visible = cmbOption.SelectedIndex == 0;
            btnDeleteUser.Visible = cmbOption.SelectedIndex == 1;
            btnAlterUser.Visible = cmbOption.SelectedIndex == 2;

            txtName.ReadOnly = cmbOption.SelectedIndex == 1;
            txtPassword.ReadOnly = cmbOption.SelectedIndex == 1;
            txtSurname.ReadOnly = cmbOption.SelectedIndex == 1;
            txtUsername.ReadOnly = cmbOption.SelectedIndex == 1;
            txtUserType.Enabled = cmbOption.SelectedIndex != 1;

        }
        private void TextBoxTextChanged(object sender, EventArgs e)
        {
            if (sender == txtName)
                InputValidation.ValidateName(lblErrorName, txtName);

            if (sender == txtSurname)
                InputValidation.ValidateSurname(lblErrorSurname, txtSurname);

            if (sender == txtUsername)
                InputValidation.ValidateUsername(lblErrorUsername, txtUsername);

            if (sender == txtPassword)
                InputValidation.ValidatePassword(lblErrorPassword, txtPassword);

        }

    }
}
