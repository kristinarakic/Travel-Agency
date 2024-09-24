using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Net.Mime.MediaTypeNames;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel;

namespace ProjekatTVP
{
    public partial class RegistrationForm : Form
    {
        StartForm StartForm;
        public RegistrationForm(StartForm startForm)
        {
            InitializeComponent();
            StartForm = startForm;
        }

        private void btnRegistrationComplete_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtName.Text) || string.IsNullOrEmpty(txtPassword.Text)
                || string.IsNullOrEmpty(txtPasswordAgain.Text) || string.IsNullOrEmpty(txtSurname.Text)
                || string.IsNullOrEmpty(txtUsername.Text))
            {
                MessageBox.Show("Morate popuniti sva polja.", "Greška", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                UserManager userManager = new UserManager();

                if (userManager.RegisterUser(txtName.Text, txtSurname.Text, txtUsername.Text, txtPassword.Text, "Client"))
                    this.Close();

            }
        }
        private void panel2_MouseClick(object sender, MouseEventArgs e)
        {
            StartForm.Show();
            this.Close();
        }
        private void TextBoxTextChanged(object sender, EventArgs e)
        {
            if (sender == txtName)
                InputValidation.ValidateName(lblErrorName, txtName);

            if (sender == txtSurname)
                InputValidation.ValidateSurname(lblErrorSurname, txtSurname);

            if (sender == txtUsername)
                InputValidation.ValidateUsername(lblErrorUsername, txtUsername);

            if (sender == txtPassword || sender == txtPasswordAgain)
                InputValidation.ValidatePassword(lblErrorPassword, txtPassword, lblErrorPasswordAgain, txtPasswordAgain);
        }
    }
}
