using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Linq;

namespace ProjekatTVP
{
    public partial class LoginForm : Form
    {
        private StartForm StartForm;
        public LoginForm(StartForm startForm)
        {
            InitializeComponent();
            StartForm = startForm;
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtPassword.Text) || string.IsNullOrEmpty(txtUsername.Text))
            {
                MessageBox.Show("Morate uneti korisničko ime i lozinku.", "Greška", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else 
            {
                if (UserManager.AuthenticateUser(txtUsername.Text, txtPassword.Text, cbType.Text, out User? user))
                {
                    if (user != null)
                        MessageBox.Show($"Dobrodošli, {user.Name1}!", "Informacija", MessageBoxButtons.OK, MessageBoxIcon.Information);

                    if (cbType.Text.Equals("Admin"))
                    {
                        AdminForm adminForm = new AdminForm(this);
                        this.Hide();
                        adminForm.ShowDialog();
                        this.Show();
                    }
                    if (cbType.Text.Equals("Klijent"))
                    {
                        ClientStartForm clientFormStart = new ClientStartForm(this);
                        this.Hide();
                        clientFormStart.ShowDialog();
                        this.Show();
                    }

                }
            }
        }
        private void TextBoxTextChanged(object sender, EventArgs e)
        {
            if (sender == txtUsername)
                InputValidation.ValidateUsername(lblErrorUsername, txtUsername);

            if (sender == txtPassword)
                InputValidation.ValidatePassword(lblErrorPassword, txtPassword);
        }

        private void panel1_MouseClick(object sender, MouseEventArgs e)
        {
            StartForm.Show();
            this.Close();
        }

        private void LoginForm_Load(object sender, EventArgs e)
        {
            cbType.SelectedIndex = 0;
        }
    }
}
