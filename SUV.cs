using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InterfacesExercise
{
    internal class SUV : IVehicle
    {
        private string _Make = string.Empty;

        private string _Model = string.Empty;

        private int _Year = 0;

        private long _VinNumber = 0;

        private int _NumberOfSeats = 0;

        private bool _HasTVS = false;

        public string Make { get { return _Make; } set { _Make = value; } }

        public string Model { get { return _Model; } set { _Model = value; } }

        public int Year { get { return _Year; } set { _Year = value; } }

        public long VinNumber { get { return _VinNumber; } set { _VinNumber = value; } }

        public int NumberOfSeats { get { return _NumberOfSeats; } set { _NumberOfSeats = value; } }

        public bool HasTVS { get { return _HasTVS; } set { _HasTVS = value; } }

        public SUV() { }

        public SUV(string make, string model, int year, long vinNumber, int numberOfSeats, bool hasTVS)
        {
            Make = make;
            Model = model;
            Year = year;
            VinNumber = vinNumber;
            NumberOfSeats = numberOfSeats;
            HasTVS = hasTVS;
        }
    }
}
