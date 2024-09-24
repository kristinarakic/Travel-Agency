using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProjekatTVP
{
    public partial class ClientForm : Form
    {
        ClientStartForm ClientStartForm;
        ReservationManager reservationManager;
        public ClientForm(ClientStartForm clientStartForm)
        {
            InitializeComponent();
            ClientStartForm = clientStartForm;
            reservationManager = new ReservationManager();
        }

        enum ReservationOptions { Create = 0, Delete = 1, Alter = 2 }

        //CUD
        private void btnCreateReservation_Click(object sender, EventArgs e)
        {

            if (listView1.SelectedItems.Count < 1)
            {
                MessageBox.Show("Morate izabrati izlet.", "Greška", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            if (string.IsNullOrEmpty(txtTravelers.Text))
            {
                MessageBox.Show("Morate uneti broj putnika.", "Greška", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            else
            {
                int travelers = int.Parse(txtTravelers.Text);
                Trip? trip = (Trip)listView1.SelectedItems[0].Tag;
                if (trip != null)
                {
                    if (reservationManager.AddReservation(UserManager.ClientsID, trip.ID1, travelers))
                    {
                        cmbOption.SelectedIndex = -1;
                        ClearAllTextboxes();
                    }
                    else
                    {
                        cmbOption.SelectedIndex = (int)ReservationOptions.Create;
                        txtTravelers.Clear();
                    }
                }
                else
                {
                    MessageBox.Show("Ne postoji izabrani izlet.", "Greška", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
            }

        }
        private void btnDeleteRezervation_Click(object sender, EventArgs e)
        {
            if (listView1.SelectedItems.Count == 0)
            {
                MessageBox.Show("Morate izabrati rezervaciju za brisanje.", "Greška", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            Reservation reservation = (Reservation)listView1.SelectedItems[0].Tag;
            
            if (reservationManager.DeleteReservation(UserManager.ClientsID, reservation.TripID1))
            {
                cmbOption.SelectedIndex = -1;
                ClearAllTextboxes();
            }
            else
                cmbOption.SelectedIndex = (int)(ReservationOptions.Delete);

        }
        private void btnAlterReservation_Click(object sender, EventArgs e)
        {
            int travelers = int.Parse(txtTravelers.Text);

            if (listView1.SelectedItems.Count == 0)
            {
                MessageBox.Show("Morate izabrati rezervaciju.", "Greška", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            Reservation reservationToUpdate = (Reservation)listView1.SelectedItems[0].Tag;
            if (reservationToUpdate != null)
            {
                reservationToUpdate.NumberOfTravelers1 = travelers;
                if (reservationManager.AlterReservation(reservationToUpdate, Double.Parse(txtPrice.Text)))
                {
                    cmbOption.SelectedIndex = -1;
                    ClearAllTextboxes();
                }
                else
                {
                    cmbOption.SelectedIndex = (int)(ReservationOptions.Alter);
                    txtTravelers.Clear();
                }
            }
            else
            {
                MessageBox.Show("Ne postoji izabrana rezervacija.", "Greška", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

        }

        //prikaz liste \ dugmeta
        private void cmbOption_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cmbOption.SelectedIndex < 0)
            {
                ReservationManager.ReservationsPrinterClients(listView1, UserManager.ClientsID);
                lblListViewCaption.Text = "Vaše rezervacije: ";
            }
            if (cmbOption.SelectedIndex == (int)ReservationOptions.Create)
            {
                ReservationManager.LoadCitiesIntoComboBox(cmbFilter);
                TripManager.TripsPrinterClients(listView1, cmbFilter.Text);
                lblListViewCaption.Text = "Izaberite izlet za rezervaciju (dupli klik): ";

            }
            if (cmbOption.SelectedIndex == (int)ReservationOptions.Delete)
            {
                ReservationManager.ReservationsPrinterClients(listView1, UserManager.ClientsID);
                lblListViewCaption.Text = "Izaberite rezervaciju za brisanje (dupli klik): ";
            }
            if (cmbOption.SelectedIndex == (int)ReservationOptions.Alter)
            {
                ReservationManager.ReservationsPrinterClients(listView1, UserManager.ClientsID);
                lblListViewCaption.Text = "Izaberite rezervaciju za izmenu (dupli klik): ";
            }
            btnCreateReservation.Visible = cmbOption.SelectedIndex == 0;
            btnDeleteRezervation.Visible = cmbOption.SelectedIndex == 1;
            btnAlterReservation.Visible = cmbOption.SelectedIndex == 2;
            cmbFilter.Visible = cmbOption.SelectedIndex == 0;
            lblFilter.Visible = cmbOption.SelectedIndex == 0;

            txtTravelers.ReadOnly = cmbOption.SelectedIndex == 1;
        }

        //printanje podataka u textbox
        private void listView1_ItemActivate(object sender, EventArgs e)
        {
            if (listView1.SelectedItems.Count == 0)
            {
                MessageBox.Show("Nije izabran nijedan izlet/rezervacija.");
                return;
            }

            Trip? trip;

            ReservationOptions selectedOption = (ReservationOptions)cmbOption.SelectedIndex;

            if (selectedOption == ReservationOptions.Create)
            {
                trip = (Trip)listView1.SelectedItems[0].Tag;
                txtCity.Text = trip.City1;
                txtDate.Text = trip.Date1.ToString("dd.MM.yyyy.");
                txtDays.Text = trip.Days1.ToString();
            }
            if (selectedOption == ReservationOptions.Alter || selectedOption == ReservationOptions.Delete)
            {
                Reservation reservation = (Reservation)listView1.SelectedItems[0].Tag;
                trip = TripManager.LoadTrips().FirstOrDefault(t => t.ID1 == reservation.TripID1);
                if (trip != null)
                {
                    txtCity.Text = trip.City1;
                    txtDate.Text = trip.Date1.ToString("dd.MM.yyyy.");
                    txtDays.Text = trip.Days1.ToString();
                    txtTravelers.Text = reservation.NumberOfTravelers1.ToString();
                    txtPrice.Text = reservation.TotalPrice1.ToString();
                }

            }
        }
        private void txtTravelers_TextChanged(object sender, EventArgs e)
        {
            LoadAndDisplayPrice();
            if (sender == txtTravelers)
                InputValidation.ValidateIntegerNumber(lblErrorTravelers, txtTravelers);
        }
        private void cmbFilter_SelectedValueChanged(object sender, EventArgs e)
        {
            TripManager.TripsPrinterClients(listView1, cmbFilter.Text);
        }
        private void ClientForm_Load(object sender, EventArgs e)
        {
            cmbOption.SelectedIndex = (int)ReservationOptions.Create;
        }
        private void panel3_MouseClick(object sender, MouseEventArgs e)
        {
            this.Close();
            ClientStartForm.Show();
        }

        //dodato
        private void LoadAndDisplayPrice()
        {
            int tripID = 0;

            if (listView1.SelectedItems.Count > 0)
            {
                if (cmbOption.SelectedIndex == (int)ReservationOptions.Alter || cmbOption.SelectedIndex == (int)ReservationOptions.Delete)
                {
                    Reservation reservation = (Reservation)listView1.SelectedItems[0].Tag;
                    tripID = reservation.TripID1;
                }
                else
                {
                    Trip? trip = (Trip)listView1.SelectedItems[0].Tag;
                    tripID = trip.ID1;
                }
                if (int.TryParse(txtTravelers.Text, out int travelers))
                {
                    double price = ReservationManager.TotalPrice(tripID, travelers);
                    txtPrice.Text = price.ToString("F2");

                }
            }

        }
        private void ClearAllTextboxes()
        {
            txtCity.Clear();
            txtDate.Clear();
            txtDays.Clear();
            txtPrice.Clear();
            txtTravelers.Clear();
        }


    }

}
