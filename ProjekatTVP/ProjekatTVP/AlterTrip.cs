using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel;
using System.Xml.Linq;
using System.Globalization;
using System.Diagnostics;

namespace ProjekatTVP
{
    public partial class AlterTrip : Form
    {
        TripManager tripManager;
        AdminForm AdminForm;

        public AlterTrip(AdminForm adminForm)
        {
            InitializeComponent();
            AdminForm = adminForm;
            tripManager = new TripManager();
        }

        //Added
        private void TextBoxCleaner()
        {
            txtCity.Text = "";
            txtDays.Text = "";
            txtDiscount.Text = "";
            txtPrice.Text = "";
            txtState.Text = "";
            txtTravelers.Text = "";

        }

        // Other
        private void AlterTrip_Load(object sender, EventArgs e)
        {
            cmbOption.SelectedIndex = 0;

            TripManager.TripsPrinter(listView1);
        }
        private void cmbOption_SelectedIndexChanged(object sender, EventArgs e)
        {
            bool checkedDeleteOption = cmbOption.SelectedIndex == 1;

            if (cmbOption.SelectedIndex == 0)
                lblListViewCaption.Text = "Prikaz izleta:";
            else if (cmbOption.SelectedIndex == 1)
                lblListViewCaption.Text = "Izaberite izlet za brisanje (dupli klik):";
            else
                lblListViewCaption.Text = "Izaberite izlet za izmenu (dupli klik):";

            txtCity.ReadOnly = checkedDeleteOption;
            txtDays.ReadOnly = checkedDeleteOption;
            txtDiscount.ReadOnly = checkedDeleteOption;
            txtPrice.ReadOnly = checkedDeleteOption;
            txtState.ReadOnly = checkedDeleteOption;
            txtTravelers.ReadOnly = checkedDeleteOption;

            btnCreateTrip.Visible = cmbOption.SelectedIndex == 0;
            btnDeleteTrip.Visible = checkedDeleteOption;
            btnAlterTrip.Visible = cmbOption.SelectedIndex == 2;
            TextBoxCleaner();
        }
        private void listView1_ItemActivate(object? sender, EventArgs e)
        {
            if (listView1.SelectedItems.Count > 0)
            {
                ListViewItem selectedItem = listView1.SelectedItems[0];

                Trip selectedTrip = (Trip)selectedItem.Tag;

                txtCity.Text = selectedTrip.City1;
                txtState.Text = selectedTrip.State1;
                txtPrice.Text = selectedTrip.Price1.ToString();
                txtDiscount.Text = selectedTrip.Discount1.ToString();
                txtDays.Text = selectedTrip.Days1.ToString();
                txtTravelers.Text = selectedTrip.NumberOfTravelers1.ToString();
                dateTimePicker1.Value = selectedTrip.Date1.ToDateTime(TimeOnly.MinValue);
            }

        }

        // OnClick
        private void btnCreateTrip_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtCity.Text) || string.IsNullOrEmpty(txtDays.Text) 
                || string.IsNullOrEmpty(txtDiscount.Text) || string.IsNullOrEmpty(txtTravelers.Text)
                 || string.IsNullOrEmpty(txtPrice.Text) || string.IsNullOrEmpty(txtState.Text))
            {
                MessageBox.Show("Popunite sva polja.", "Greška", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            else
            {
                DateOnly date = DateOnly.FromDateTime(dateTimePicker1.Value);
                int days = int.Parse(txtDays.Text);
                int discount = int.Parse(txtDiscount.Text);
                double price = Double.Parse(txtPrice.Text);
                int travelers = int.Parse(txtTravelers.Text);
                tripManager.AddTrip(txtCity.Text, txtState.Text, price, discount, days, travelers, date);
                TripManager.TripsPrinter(listView1);
                TextBoxCleaner();
            }

        }
        private void btnAlterTrip_Click(object sender, EventArgs e)
        {
            DateOnly date = DateOnly.FromDateTime(dateTimePicker1.Value);
            int days = 0;
            int discount = 0;
            double price = 0;
            int travelers = 0;

            if (listView1.SelectedItems.Count < 1)
            {
                MessageBox.Show("Morate izabrati izlet za izmenu.", "Greška", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            if (string.IsNullOrEmpty(txtCity.Text) || string.IsNullOrEmpty(txtTravelers.Text)
             || string.IsNullOrEmpty(txtDays.Text) || string.IsNullOrEmpty(txtDiscount.Text)
               || string.IsNullOrEmpty(txtPrice.Text) || string.IsNullOrEmpty(txtState.Text))
            {
                MessageBox.Show("Morate popuniti sva polja.", "Greška", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            else
            {
                date = DateOnly.FromDateTime(dateTimePicker1.Value);
                days = int.Parse(txtDays.Text);
                discount = int.Parse(txtDiscount.Text);
                price = Double.Parse(txtPrice.Text);
                travelers = int.Parse(txtTravelers.Text);
            }
          
            lblListViewCaption.Text = "Izaberite izlet za izmenu (dupli klik):";

            Trip? tripToUpdate = (Trip)listView1.SelectedItems[0].Tag;
            if (tripToUpdate != null)
            {
                tripToUpdate.City1 = txtCity.Text;
                tripToUpdate.State1 = txtState.Text;
                tripToUpdate.Price1 = price;
                tripToUpdate.Discount1 = discount;
                tripToUpdate.Days1 = days;
                tripToUpdate.NumberOfTravelers1 = travelers;
                tripToUpdate.Date1 = date;

                tripManager.AlterTrip(tripToUpdate);

                TripManager.TripsPrinter(listView1);
                TextBoxCleaner();
            }
            else
            {
                MessageBox.Show("Izabrani izlet ne postoji.", "Greška", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            

        }
        private void btnDeleteTrip_Click(object sender, EventArgs e)
        {
            if (listView1.SelectedItems.Count > 0)
            {
                Trip tripToDelete = (Trip)listView1.SelectedItems[0].Tag;

                tripManager.DeleteTrip(tripToDelete.ID1);

                TripManager.TripsPrinter(listView1);
                TextBoxCleaner();
            }
            else
            {
                MessageBox.Show("Morate izabrati izlet za brisanje.", "Greška", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
        }
        private void panel2_MouseClick(object sender, MouseEventArgs e)
        {
            this.Close();
        }
        private void TextBoxTextChanged(object sender, EventArgs e)
        {
            if (sender == txtCity)
                InputValidation.ValidateCity(lblErrorCity, txtCity);
            if (sender == txtState)
                InputValidation.ValidateState(lblErrorState, txtState);
            if (sender == txtDays)
                InputValidation.ValidateIntegerNumber(lblErrorDays, txtDays);
            if (sender == txtDiscount)
                InputValidation.ValidateIntegerNumber(lblErrorDiscount, txtDiscount);
            if (sender == txtPrice)
                InputValidation.ValidateDoubleNumber(lblErrorPrice, txtPrice);
            if (sender == txtTravelers)
                InputValidation.ValidateIntegerNumber(lblErrorTravelers, txtTravelers);
        }
    }
}
