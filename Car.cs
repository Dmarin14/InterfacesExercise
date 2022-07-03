using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InterfacesExercise
{
    internal class Car : IVehicle
    {
        private string _Make = string.Empty;

        private string _Model = string.Empty;

        private int _Year = 0;

        private long _VinNumber = 0;

        private string _Color = string.Empty;

        private int _MaxSpeed = 0;

        public string Make { get { return _Make; } set { _Make = value; } }

        public string Model { get { return _Model; } set { _Model = value; } }

        public int Year { get { return _Year; } set { _Year = value; } }

        public long VinNumber { get { return _VinNumber; } set { _VinNumber = value; } }

        public string Color { get { return _Color; } set { _Color = value; } }
   

        public int MaxSpeed { get { return _MaxSpeed; } set { _MaxSpeed = value; } }
      

        public Car() { }

        public Car(string make, string model, int year, long vinNumber, string color, int maxSpeed)
        {
            Make = make;
            Model = model;
            Year = year;
            VinNumber = vinNumber;
            Color = color;
            MaxSpeed = maxSpeed;
        }

       


    }
}
