using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Globalization;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace ProjekatTVP
{
    public class ReservationManager
    {
        private  List<Reservation> reservations;

        public ReservationManager()
        {
            reservations = LoadReservations() ?? new List<Reservation>();
        }

        public static List<Reservation> LoadReservations()
        {
            if (File.Exists("reservations.json"))
            {
                try
                {
                    string json = File.ReadAllText("reservations.json");

                    var deserializedReservations = JsonConvert.DeserializeObject<List<Reservation>>(json);

                    return deserializedReservations ?? new List<Reservation>();
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"Došlo je do greške prilikom čitanja: {ex.Message}");
                    return new List<Reservation>(); 
                }
            }
            else
            {
                MessageBox.Show("Fajl rezervacije.json ne postoji.");
                return new List<Reservation>(); 
            }
        }
        public static void SaveReservations(List<Reservation> reservations)
        {
            try
            {
                string json = JsonConvert.SerializeObject(reservations, Formatting.Indented);

                File.WriteAllText("reservations.json", json);

            }
            catch (Exception ex)
            {
                MessageBox.Show($"Došlo je do greške prilikom upisa u fajl: {ex.Message}");
            }
        }
        public bool AddReservation(int userID, int tripID, int travelers)
        {
            if (reservations.Any(r => r.UserID1 == userID &&
                                    r.TripID1 == tripID))
            {
                MessageBox.Show($"Uneta rezervacija već postoji.", "Greška", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }

            if (TotalPrice(tripID, travelers) == 0)
                return false;

            if (UpdateTripTravelers(tripID, travelers, 0) && TripCheck(tripID, userID))
            {
                reservations.Add(new Reservation(userID, tripID, TotalPrice(tripID, travelers), travelers));
                SaveReservations(reservations);
                MessageBox.Show("Rezervacija uspešno dodata!", "Informacija", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return true;
            }
            else
                return false;
        }
        public static double TotalPrice(int tripID, int travelers)
        {
            if (travelers <= 0)
            {
                MessageBox.Show("Broj putnika mora biti veći od nule.", "Greška", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return 0;
            }

            Trip? trip = TripManager.LoadTrips().FirstOrDefault(t => t.ID1 == tripID);

            if (trip != null)
            {
                double discountedPrice = trip.Price1 * (1 - trip.Discount1 / 100.0);
                double price = travelers * discountedPrice;
                return price;
            }
            else
            {
                MessageBox.Show("Nije pronađen izlet sa unetim ID-em.", "Greška", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return 0;
            }
        }
        private bool UpdateTripTravelers(int tripID, int newTravelers, int oldTravelers)
        {
            List<Trip> trips = TripManager.LoadTrips();
            Trip? trip = trips.FirstOrDefault(t => t.ID1 == tripID);

            if (trip != null)
            {
                int difference = newTravelers - oldTravelers;

                if (difference > 0) 
                {
                    if (trip.NumberOfTravelers1 >= difference)
                    {
                        trip.NumberOfTravelers1 -= difference;
                        TripManager.SaveTrips(trips);
                        return true;
                    }
                    else
                    {
                        MessageBox.Show($"Nema dovoljno mesta za unet broj putnika (Preostalo: {trip.NumberOfTravelers1}).", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        return false;
                    }
                }
                else if (difference < 0) 
                {
                    trip.NumberOfTravelers1 += Math.Abs(difference); 
                    TripManager.SaveTrips(trips);
                    return true;
                }
                else 
                {
                    return true; 
                }
            }
            else
            {
                MessageBox.Show("Nije pronađen izlet sa unetim ID-em", "Greška", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
        }
        private bool TripCheck(int tripID, int userID)
        {
            var allTrips = TripManager.LoadTrips();
           
            foreach (var reservation in reservations)
            {
                if (reservation.UserID1 == userID)
                {
                    int foundTripID = reservation.TripID1;

                    Trip? chosenTrip = allTrips.FirstOrDefault(t => t.ID1 == tripID);
                    Trip? foundTrip = allTrips.FirstOrDefault(t => t.ID1 == foundTripID);

                    if (chosenTrip == null)
                    {
                        MessageBox.Show("Izlet koji želite da rezervišete ne postoji.", "Greška", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        return false;
                    }

                    if (foundTrip == null)
                    {
                        MessageBox.Show("Izlet sa pronađenim ID-em ne postoji.", "Greška", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        return false;
                    }

                    if (foundTrip.Date1 == chosenTrip.Date1)
                    {
                        MessageBox.Show("Ne možete rezervisati izlete sa istim datumom.", "Greška", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        return false;
                    }
                }
            }
            return true;
        }
        public bool AlterReservation(Reservation reservationToUpdate, double newPrice) 
        {
            bool isFound = false;
            int oldTravelers = 0;
            int newTravelers = reservationToUpdate.NumberOfTravelers1;

            for (int i = 0; i < reservations.Count; i++)
            {
                if (reservations[i].UserID1 == reservationToUpdate.UserID1 &&
                    reservations[i].TripID1 == reservationToUpdate.TripID1)
                {
                    oldTravelers = reservations[i].NumberOfTravelers1;
                    reservations[i].NumberOfTravelers1 = newTravelers;
                    reservations[i].TotalPrice1 = newPrice;
                    isFound = true;
                    break;
                }
            }

            if (isFound)
            {
                if (UpdateTripTravelers(reservationToUpdate.TripID1, newTravelers, oldTravelers))
                {
                    SaveReservations(reservations);
                    MessageBox.Show("Uspešno izmenjena rezervacija.", "Informacija", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    return true;
                }
                else
                    return false;
              
            }
            else
            {
                MessageBox.Show("Korisnik ili izlet sa unetim ID-em nisu nije pronađen.", "Greška", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
        }
        public bool DeleteReservation(int userID, int tripID)
        {
            var reservationToDelete = reservations.FirstOrDefault(r => r.UserID1 == userID && r.TripID1 == tripID);

            if (reservationToDelete == null)
            {
                MessageBox.Show("Izlet sa zadatim ID-em nije pronađen.", "Greška", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }

            if (UpdateTripTravelers(tripID, 0, reservationToDelete.NumberOfTravelers1))
            {
                reservations.Remove(reservationToDelete);
                SaveReservations(reservations);
                MessageBox.Show("Uspešno obrisana rezervacija.", "Informacija", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return true;

            }
            else
                return false;
           
        }
        public static void ReservationsPrinter(ListView listView1)
        {
            listView1.Items.Clear();
            listView1.Columns.Clear();

            listView1.View = View.Details;
            listView1.Columns.Add("ID korisnika", 80, HorizontalAlignment.Left);
            listView1.Columns.Add("ID izleta", 80, HorizontalAlignment.Left);
            listView1.Columns.Add("Ukupna cena", 100, HorizontalAlignment.Left);
            listView1.Columns.Add("Broj mesta", 80, HorizontalAlignment.Left);
            listView1.Columns.Add("Datum", 110, HorizontalAlignment.Left);

            foreach (Reservation reservation in ReservationManager.LoadReservations())
            {
                var item = new ListViewItem(reservation.UserID1.ToString());
                item.SubItems.Add(reservation.TripID1.ToString());
                item.SubItems.Add(reservation.TotalPrice1.ToString("F2"));
                item.SubItems.Add(reservation.NumberOfTravelers1.ToString());
                item.SubItems.Add(reservation.TimeOfReservation1.ToString("dd.MM.yyyy."));
                listView1.Items.Add(item);

                item.Tag = reservation;
            }
        }
        public static void ReservationsPrinterClients(ListView listView1, int? userID = null)
       {
            listView1.Items.Clear();
            listView1.Columns.Clear();

            listView1.View = View.Details;

            listView1.Columns.Add("Mesto", 80, HorizontalAlignment.Left);
            listView1.Columns.Add("Datum", 110, HorizontalAlignment.Left);
            listView1.Columns.Add("Ukupna cena", 80, HorizontalAlignment.Left);
            listView1.Columns.Add("Broj dana", 80, HorizontalAlignment.Left);
            listView1.Columns.Add("Broj putnika", 80, HorizontalAlignment.Left);

            var allTrips = TripManager.LoadTrips().ToDictionary(t => t.ID1, t => t);

            var reservations = userID.HasValue 
                ? LoadReservations().Where(r => r.UserID1 == userID.Value).ToList() 
                : LoadReservations();

            foreach (Reservation reservation in reservations)
            {
                if (allTrips.TryGetValue(reservation.TripID1, out Trip? trip))
                {
                    var item = new ListViewItem(trip.City1);
                    item.SubItems.Add(trip.Date1.ToString("dd.MM.yyyy.")); 
                    item.SubItems.Add(reservation.TotalPrice1.ToString("F2"));
                    item.SubItems.Add(trip.Days1.ToString());
                    item.SubItems.Add(reservation.NumberOfTravelers1.ToString());
                    listView1.Items.Add(item);

                    item.Tag = reservation;
                }
            }
       }
        public static void PrintUsersFilteredReservations(ListView listView1, List<Reservation> filteredReservations)
        {
            listView1.Items.Clear();
            listView1.Columns.Clear();

            listView1.View = View.Details;

            listView1.Columns.Add("Mesto", 80, HorizontalAlignment.Left);
            listView1.Columns.Add("Datum", 110, HorizontalAlignment.Left);
            listView1.Columns.Add("Ukupna cena", 80, HorizontalAlignment.Left);
            listView1.Columns.Add("Broj dana", 80, HorizontalAlignment.Left);
            listView1.Columns.Add("Broj putnika", 80, HorizontalAlignment.Left);

            var allTrips = TripManager.LoadTrips().ToDictionary(t => t.ID1, t => t);

            filteredReservations = filteredReservations.Where(r=> r.UserID1 == UserManager.ClientsID).ToList();

            foreach (Reservation reservation in filteredReservations)
            {
                if (allTrips.TryGetValue(reservation.TripID1, out Trip? trip))
                {
                    var item = new ListViewItem(trip.City1);
                    item.SubItems.Add(trip.Date1.ToString("dd.MM.yyyy.")); 
                    item.SubItems.Add(reservation.TotalPrice1.ToString("C", CultureInfo.CreateSpecificCulture("fr-FR"))); 
                    item.SubItems.Add(trip.Days1.ToString());
                    item.SubItems.Add(reservation.NumberOfTravelers1.ToString());
                    listView1.Items.Add(item);

                    item.Tag = reservation;
                }
            }
        }

        public static void LoadCitiesIntoComboBox(ComboBox cmbFilter)
        {
            cmbFilter.Items.Clear();

            var trips = TripManager.LoadTrips();

            foreach (var trip in trips)
            {
                if (!cmbFilter.Items.Contains(trip.City1)) 
                    cmbFilter.Items.Add(trip.City1);
            }

            
        }
        public static List<Reservation> FilterReservationsByDate(DateTime startDate, DateTime endDate)
        {
            List<Reservation> filteredReservations = new List<Reservation>();
            DateTime timeOfReservation;
            foreach (var reservation in LoadReservations())
            {
                timeOfReservation = reservation.TimeOfReservation1.Date;
                if (timeOfReservation>= startDate && timeOfReservation <= endDate)
                {
                    filteredReservations.Add(reservation);
                }
            }
            if (!filteredReservations.Any())
                MessageBox.Show("Nemate nijednu rezervaciju u tom vremenskom periodu", "Greška", MessageBoxButtons.OK, MessageBoxIcon.Error);
            return filteredReservations;
        }


    }
}
