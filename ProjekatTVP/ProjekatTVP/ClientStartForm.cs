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
    public partial class ClientStartForm : Form
    {
        LoginForm LoginForm;
        ReservationManager reservationManager;

        public ClientStartForm(LoginForm loginForm)
        {
            InitializeComponent();
            LoginForm = loginForm;
            reservationManager = new ReservationManager();
        }

        private void dateTimePicker_ValueChanged(object sender, EventArgs e)
        {
            DateTime startDate = dtpStart.Value.Date;
            DateTime endDate = dtpEnd.Value.Date;

            if (startDate > endDate)
            {
                MessageBox.Show("Početni datum mora biti pre krajnjeg datuma.", "Greška", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            List<Reservation> filteredReservations = ReservationManager.FilterReservationsByDate(startDate, endDate);
            ReservationManager.PrintUsersFilteredReservations(listView1, filteredReservations);

            lblCaptionListView.Text = $"Rezeravacije u periodu {startDate.Date.ToString("dd.MM.yyyy")} - {endDate.Date.ToString("dd.MM.yyyy")} ";
        }

        private void ClientStartForm_Load(object sender, EventArgs e)
        {
            ReservationManager.ReservationsPrinterClients(listView1, UserManager.ClientsID);
            lblCaptionListView.Text = "Sve rezervacije: ";
        }
        private void btnAlterReservations_Click(object sender, EventArgs e)
        {
            ClientForm clientForm = new ClientForm(this);
            this.Hide();
            clientForm.ShowDialog();
            this.Show();
        }

        private void panel2_MouseClick(object sender, MouseEventArgs e)
        {
            this.Close();
            LoginForm.Show();
        }
    }
}
