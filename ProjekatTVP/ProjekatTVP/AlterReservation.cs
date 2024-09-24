using Microsoft.VisualBasic;
using Microsoft.VisualBasic.ApplicationServices;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProjekatTVP
{
    public partial class AlterReservation : Form
    {
        AdminForm AdminForm;
        ReservationManager reservationManager;
        public AlterReservation(AdminForm adminForm)
        {
            InitializeComponent();
            AdminForm = adminForm;
            reservationManager = new ReservationManager();
            txtTravelers.TextChanged += TextBoxTextChanged;
            cmbOption.SelectedIndexChanged += cmbOption_SelectedIndexChanged;
        }

        //Added
        private void LoadAndDisplayPrice()
        {
            if (int.TryParse(txtTripID.Text, out int tripID) &&
                int.TryParse(txtTravelers.Text, out int travelers))
            {
                double price = ReservationManager.TotalPrice(tripID, travelers);
                txtPrice.Text = price.ToString("F2");

            }
        }
        private void CleanTextBoxes()
        {
            txtPrice.Text = "";
            txtTravelers.Text = "";
            txtTripID.Text = "";
            txtUserID.Text = "";
        }


        //Other
        private void cmbOption_SelectedIndexChanged(object sender, EventArgs e)
        {
            btnCreateReservation.Visible = cmbOption.SelectedIndex == 0;
            btnDeleteRezervation.Visible = cmbOption.SelectedIndex == 1;
            btnAlterReservation.Visible = cmbOption.SelectedIndex == 2;

            cmbPrint.Visible = cmbOption.SelectedIndex == 0;
            lblCmbPrint.Visible = cmbOption.SelectedIndex == 0;

            txtPrice.ReadOnly = cmbOption.SelectedIndex == 1;
            txtTripID.ReadOnly = cmbOption.SelectedIndex != 0;
            txtUserID.ReadOnly = cmbOption.SelectedIndex != 0;
            txtTravelers.ReadOnly = cmbOption.SelectedIndex == 1;

            if (cmbOption.SelectedIndex == -1) 
            {
                ReservationManager.ReservationsPrinter(listView1);
                lblListViewCaption.Text = "Sve rezervacije: ";
            }
            if (cmbOption.SelectedIndex == 1)
            {
                lblListViewCaption.Text = "Izaberite rezervaciju za brisanje (dupli klik): ";
                ReservationManager.ReservationsPrinter(listView1);
            }
            if (cmbOption.SelectedIndex == 2)
            {
                ReservationManager.ReservationsPrinter(listView1);
                lblListViewCaption.Text = "Izaberite rezervaciju za izmenu (dupli klik): ";
            }

        }
        private void AlterReservation_Load(object sender, EventArgs e)
        {
            cmbOption.SelectedIndex = 0;
            cmbPrint.SelectedIndex = 0;
        }
        private void cmbPrint_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cmbOption.SelectedIndex == 0)
            {
                if (cmbPrint.SelectedIndex == 0)
                {
                    lblListViewCaption.Text = "Izaberite klijenta (dupli klik): ";
                    UserManager.UsersPrinter("clients.json", listView1);
                }
                if (cmbPrint.SelectedIndex == 1)
                {
                    lblListViewCaption.Text = "Izaberite izlet (dupli klik): ";
                    TripManager.TripsPrinter(listView1);
                }
            }
           
        }
        private void listView1_ItemActivate(object sender, EventArgs e)
        {
            object tag = listView1.SelectedItems[0].Tag;
            if (cmbPrint.Visible)
            {
                if (cmbPrint.SelectedIndex == 0)
                {
                    if (tag is User client)
                    {
                        txtUserID.Text = client.ID1.ToString();
                    }
                }
                if (cmbPrint.SelectedIndex == 1)
                {
                    if (tag is Trip trip)
                        txtTripID.Text = trip.ID1.ToString();
                }
            }

            if (cmbOption.SelectedIndex == 1 || cmbOption.SelectedIndex == 2)
            {
                if (tag is Reservation reservation)
                {
                    txtTravelers.Text = reservation.NumberOfTravelers1.ToString();
                    txtPrice.Text = reservation.TotalPrice1.ToString("F2");
                    txtTripID.Text = reservation.TripID1.ToString();
                    txtUserID.Text = reservation.UserID1.ToString();
                }
                {
                    MessageBox.Show("Morate izabrati rezervaciju!", "Greška", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                
            }

        }
        private void txtTravelers_TextChanged(object sender, EventArgs e)
        {
            LoadAndDisplayPrice();
        }

        //OnClick
        private void btnCreateReservation_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtTripID.Text) || string.IsNullOrEmpty(txtUserID.Text) 
                || string.IsNullOrEmpty(txtTravelers.Text))
            {
                MessageBox.Show("Morate popuniti sva polja. ", "Greška", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            else
            {
                int userID = int.Parse(txtUserID.Text);
                int tripID = int.Parse(txtTripID.Text);
                int travelers = int.Parse(txtTravelers.Text);
                if (reservationManager.AddReservation(userID, tripID, travelers))
                {
                    ReservationManager.ReservationsPrinter(listView1);
                    cmbOption.SelectedIndex = -1;
                }
                CleanTextBoxes();
            }
        }
        private void btnAlterReservation_Click(object sender, EventArgs e)
        {

            if (listView1.SelectedItems.Count < 1)
            {
                MessageBox.Show("Morate izabrati rezervaciju za izmenu.", "Greška", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
              
            }
            else if  (string.IsNullOrEmpty(txtTravelers.Text) || string.IsNullOrEmpty(txtTripID.Text)
                        || string.IsNullOrEmpty(txtUserID.Text))
            {
                MessageBox.Show("Morate popuniti sva polja.", "Greška", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                int travelers = int.Parse(txtTravelers.Text);
                Reservation reservationToUpdate = (Reservation)listView1.SelectedItems[0].Tag;

                reservationToUpdate.NumberOfTravelers1 = travelers;
                reservationManager.AlterReservation(reservationToUpdate, Double.Parse(txtPrice.Text));
                ReservationManager.ReservationsPrinter(listView1);
            }
            CleanTextBoxes();
        }
        private void btnDeleteRezervation_Click(object sender, EventArgs e)
        {
            if (listView1.SelectedItems.Count > 0)
            {
                Reservation reservationToDelete = (Reservation)listView1.SelectedItems[0].Tag;
                reservationManager.DeleteReservation(reservationToDelete.UserID1, reservationToDelete.TripID1);
                ReservationManager.ReservationsPrinter(listView1);
            }
            else
            {
                MessageBox.Show("Morate izabrati rezervaciju za brisanje.", "Greška", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            CleanTextBoxes();
        }
        private void panel2_MouseClick(object sender, MouseEventArgs e)
        {
            this.Close();
        }
        private void TextBoxTextChanged(object sender, EventArgs e)
        {
            if (sender == txtUserID)
                InputValidation.ValidateIntegerNumber(lblErrorUserID, txtUserID);
            if (sender == txtTripID)
                InputValidation.ValidateIntegerNumber(lblErrorTripID, txtTripID);
            if (sender == txtTravelers)
                InputValidation.ValidateIntegerNumber(lblErrorTravelers, txtTravelers);
        }

    }
}
