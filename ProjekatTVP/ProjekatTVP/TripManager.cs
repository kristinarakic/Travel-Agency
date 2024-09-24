using Microsoft.VisualBasic.ApplicationServices;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjekatTVP
{
    public class TripManager
    {
        private List<Trip> trips;

        public TripManager()
        {
            trips = LoadTrips();
        }
        private int GetNextTripID()
        {
            int nextID = 1;

            trips.Sort((a, b) => a.ID1.CompareTo(b.ID1));

            for (int i = 0; i < trips.Count; i++)
            {
                if (trips[i].ID1 == nextID)
                    nextID++;
                else if (trips[i].ID1 > nextID)
                    return nextID;
            }

            return nextID;
        }
        public static List<Trip> LoadTrips()
        {
            if (File.Exists("trips.json"))
            {
                try
                {
                    string json = File.ReadAllText("trips.json");
                    var deserializedTrips = JsonConvert.DeserializeObject<List<Trip>>(json) ?? new List<Trip>();
                    return deserializedTrips;
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"Došlo je do greške prilikom čitanja: {ex.Message}");
                    return new List<Trip>(); 
                }
            }
            else
            {
                MessageBox.Show("Fajl za upis izleta ne postoji.");
                return new List<Trip>(); 
            }
        }
        public static void SaveTrips(List<Trip> trips)
        {
            try
            {
                string json = JsonConvert.SerializeObject(trips, Formatting.Indented);

                File.WriteAllText("trips.json", json);
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Došlo je do greške prilikom upisu izleta: {ex.Message}");
            }
        }
        public bool AddTrip(string city, string state, double price, int discount, int days, int travelers, DateOnly date)
        {
            if (trips.Any(t => t.City1 == city &&
                            t.State1 == state &&
                            t.Price1 == price &&
                            t.Date1 == date))
            {
                MessageBox.Show($"Uneti izlet već postoji.", "Greška", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }

            if (AddAlterTripErrors(date, discount))
            {
                MessageBox.Show("Uspešno dodat izlet.", "Informacija", MessageBoxButtons.OK, MessageBoxIcon.Information);
                trips.Add(new Trip(GetNextTripID(), city, state, price, discount, days, travelers, date));
                SaveTrips(trips);
                return true;
            }
            return false;
        }
        public bool AlterTrip(Trip tripToUpdate)
        {
            bool isTripForUpdateFound = false;

            for (int i = 0; i < trips.Count; i++)
            {
                if (trips[i].ID1 == tripToUpdate.ID1)
                {
                    if (ReservationsExistForTrip(trips[i].ID1))
                    {
                        MessageBox.Show("Neuspešna izmena - postoje rezervacije za taj izlet.", "Greška", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        return false;
                    }
                    trips[i].City1 = tripToUpdate.City1;
                    trips[i].State1 = tripToUpdate.State1;
                    trips[i].Price1 = tripToUpdate.Price1;
                    trips[i].Discount1 = tripToUpdate.Discount1;
                    trips[i].Days1 = tripToUpdate.Days1;
                    trips[i].NumberOfTravelers1 = tripToUpdate.NumberOfTravelers1;
                    trips[i].Date1 = tripToUpdate.Date1;
                    isTripForUpdateFound = true;
                    break;
                }
            }

            if (AddAlterTripErrors(tripToUpdate.Date1, tripToUpdate.Discount1))
            {
                if (isTripForUpdateFound)
                {
                    SaveTrips(trips);
                    MessageBox.Show("Uspešno izmenjen izlet.", "Informacija", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    return true;
                }
                else
                {
                    MessageBox.Show("Izlet sa zadatim ID-em nije pronađen.", "Greška", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return false;
                }
            }
            else
            {
                return false;
            }


        }
        public bool DeleteTrip(int tripID)
        {
            var tripToDelete = trips.FirstOrDefault(t => t.ID1 == tripID);

            if (tripToDelete == null)
            {
                MessageBox.Show("Izlet sa zadatim ID-om nije pronađen.", "Greška", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }

            if (ReservationsExistForTrip(tripID))
            {
                MessageBox.Show("Neuspešno brisanje - postoje rezervacije za taj izlet.", "Greška", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }

            trips.Remove(tripToDelete);

            SaveTrips(trips);
            MessageBox.Show("Uspešno obrisan izlet.", "Informacija", MessageBoxButtons.OK, MessageBoxIcon.Information);
            return true;
           
        }
        private bool ReservationsExistForTrip(int tripID)
        {
            List<Reservation> reservations = ReservationManager.LoadReservations();

            if (reservations == null)
            {
                MessageBox.Show("Ne postoji lista rezervacija.", "Greška", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }

            if (reservations.Count == 0)
            {
                return false;
            }

            return reservations.Any(r => r.TripID1 == tripID);
        }
        private bool AddAlterTripErrors(DateOnly date, int discount)
        {
            if (discount > 100 || discount < 1)
            {
                MessageBox.Show("Popust mora biti u opsegu 1-100.", "Upozorenje", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }
            if (date.Month > 12 || date.Month < 1)
            {
                MessageBox.Show("Mesec mora biti između 1 i 12.", "Upozorenje", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }
            if (date.Year > 2026)
            {
                MessageBox.Show("Godina može biti maksimalno 2026.", "Upozorenje", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }
            if (date.Day > 31 || date.Day < 1)
            {
                MessageBox.Show("Mesec mora biti od 1 do 31.", "Upozorenje", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }
            if (date.Month == 4 || date.Month == 6 || date.Month == 9 || date.Month == 11)
            {
                if (date.Day > 30)
                {
                    MessageBox.Show("Izabrani mesec može imati najviše 30 dana.", "Upozorenje", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return false;
                }
            }
            else if (date.Month == 2)
            {
                int maxDaysInFebruary = DateTime.IsLeapYear(date.Year) ? 29 : 28;
                if (date.Day > maxDaysInFebruary)
                {
                    MessageBox.Show($"Februar u {date.Year}. godini može imati najviše {maxDaysInFebruary} dana.", "Greška", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return false;
                }

            }
            if (date < DateOnly.FromDateTime(DateTime.Now))
            {
                MessageBox.Show("Datum izleta ne može biti u prošlosti.", "Greška", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
            return true;
        }
        public static void TripsPrinter(ListView listView1)
        {
            listView1.Items.Clear();
            listView1.Columns.Clear();

            listView1.View = View.Details;
            listView1.Columns.Add("ID", 40, HorizontalAlignment.Left);
            listView1.Columns.Add("Mesto", 80, HorizontalAlignment.Left);
            listView1.Columns.Add("Država", 80, HorizontalAlignment.Left);
            listView1.Columns.Add("Cena", 60, HorizontalAlignment.Left);
            listView1.Columns.Add("Popust", 60, HorizontalAlignment.Left);
            listView1.Columns.Add("Broj dana", 80, HorizontalAlignment.Left);
            listView1.Columns.Add("Ukupno mesta", 100, HorizontalAlignment.Left);
            listView1.Columns.Add("Datum", 110, HorizontalAlignment.Left);


            foreach (Trip trip in TripManager.LoadTrips())
            {
                var item = new ListViewItem(trip.ID1.ToString());
                item.SubItems.Add(trip.City1);
                item.SubItems.Add(trip.State1);
                item.SubItems.Add(trip.Price1.ToString());
                item.SubItems.Add(trip.Discount1.ToString());
                item.SubItems.Add(trip.Days1.ToString());
                item.SubItems.Add(trip.NumberOfTravelers1.ToString());
                item.SubItems.Add(trip.Date1.ToString("dd.MM.yyyy."));

                item.Tag = trip;

                listView1.Items.Add(item);
            }
        }
        public static void TripsPrinterClients(ListView listView1, string? filterCity = null)
        {
            listView1.Items.Clear();
            listView1.Columns.Clear();

            listView1.View = View.Details;
            listView1.Columns.Add("Mesto", 80, HorizontalAlignment.Left);
            listView1.Columns.Add("Država", 80, HorizontalAlignment.Left);
            listView1.Columns.Add("Cena", 60, HorizontalAlignment.Left);
            listView1.Columns.Add("Popust", 60, HorizontalAlignment.Left);
            listView1.Columns.Add("Broj dana", 80, HorizontalAlignment.Left);
            listView1.Columns.Add("Ukupno mesta", 100, HorizontalAlignment.Left);
            listView1.Columns.Add("Datum", 110, HorizontalAlignment.Left);

            var trips = TripManager.LoadTrips();

            foreach (Trip trip in trips)
            {
                if ((!string.IsNullOrEmpty(filterCity) 
                    && !trip.City1.Equals(filterCity, StringComparison.OrdinalIgnoreCase))
                    || trip.NumberOfTravelers1 < 1)
                {
                    continue;
                }

                var item = new ListViewItem(trip.City1.ToString());
                item.SubItems.Add(trip.State1);
                item.SubItems.Add(trip.Price1.ToString());
                item.SubItems.Add(trip.Discount1.ToString());
                item.SubItems.Add(trip.Days1.ToString());
                item.SubItems.Add(trip.NumberOfTravelers1.ToString());
                item.SubItems.Add(trip.Date1.ToString("dd.MM.yyyy.")); 

                item.Tag = trip;

                listView1.Items.Add(item);
            }
        }



    }
}
