using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProjekatTVP
{
    public partial class AdminForm : Form
    {
        private LoginForm LoginForm;
        public AdminForm(LoginForm loginForm)
        {
            InitializeComponent();
            LoginForm = loginForm;
        }

        private void btnBackAdmin_Click(object sender, EventArgs e)
        {
            LoginForm.Show();
            this.Close();
        }

        private void btnChangeUser_Click(object sender, EventArgs e)
        {
            AlterUser alterKorisnik = new AlterUser(this);
            this.Hide();
            alterKorisnik.ShowDialog();
            this.Show();
        }

        private void btnChangeTrip_Click(object sender, EventArgs e)
        {
            AlterTrip alterTrip = new AlterTrip(this);
            this.Hide();
            alterTrip.ShowDialog();
            this.Show();
        }

        private void btnChangeReservation_Click(object sender, EventArgs e)
        {
            AlterReservation alterReservation = new AlterReservation(this);
            this.Hide();
            alterReservation.ShowDialog();
            this.Show();
        }
        private void panel1_MouseClick(object sender, MouseEventArgs e)
        {
            this.Close();
            LoginForm.Show();
        }
    }
}
