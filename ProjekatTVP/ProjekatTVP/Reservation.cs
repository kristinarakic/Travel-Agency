using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjekatTVP
{
    [Serializable]
    public class Reservation
    {
        private int UserID;
        private int TripID;
        private double TotalPrice;
        private int NumberOfTravelers;
        private DateTime TimeOfReservation;

        public Reservation(int userID, int tripID, double totalPrice, int numberOfTravelers)
        {
            UserID = userID;
            TripID = tripID;
            TotalPrice = totalPrice;
            NumberOfTravelers = numberOfTravelers;
            TimeOfReservation = DateTime.Now;
        }

        public int UserID1 { get => UserID; set => UserID = value; }
        public int TripID1 { get => TripID; set => TripID = value; }
        public double TotalPrice1 { get => TotalPrice; set => TotalPrice = value; }
        public int NumberOfTravelers1 { get => NumberOfTravelers; set => NumberOfTravelers = value; }
        public DateTime TimeOfReservation1 { get => TimeOfReservation; set => TimeOfReservation = value; }
        public override string? ToString()
        {
            return "Datum: " + TimeOfReservation1;
        }
    }
}
