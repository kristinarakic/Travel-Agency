using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel;
using System.Xml.Linq;

namespace ProjekatTVP
{
    [Serializable]
    public class Trip
    {
        private int ID;
        private string City;
        private string State;
        private double Price;
        private int Discount;
        private int Days;
        private int NumberOfTravelers;
        private DateOnly Date;

        public Trip(int iD, string city, string state, double price, int discount, int days, int numberOfTravelers, DateOnly date)
        {
            ID = iD;
            City = city;
            State = state;
            Price = price;
            Discount = discount;
            Days = days;
            NumberOfTravelers = numberOfTravelers;
            Date = date;
        }

        public int ID1 { get => ID; set => ID = value; }
        public string City1 { get => City; set => City = value; }
        public string State1 { get => State; set => State = value; }
        public double Price1 { get => Price; set => Price = value; }
        public int Discount1 { get => Discount; set => Discount = value; }
        public int Days1 { get => Days; set => Days = value; }
        public int NumberOfTravelers1 { get => NumberOfTravelers; set => NumberOfTravelers = value; }
        public DateOnly Date1 { get => Date; set => Date = value; }

    }
}
