using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InterfacesExercise
{
    internal class Truck : IVehicle
    {
        private string _Make = string.Empty;

        private string _Model = string.Empty;

        private int _Year = 0;

        private long _VinNumber = 0;

        private bool _Is4WheelDrive = false;

        private bool _IsLifted = false;

     

        public string Make { get { return _Make; } set { _Make = value; } }

        public string Model { get { return _Model; } set { _Model = value; } }

        public int Year { get { return _Year; } set { _Year = value; } }

        public long VinNumber { get { return _VinNumber; } set { _VinNumber = value; } }

        public bool Is4WheelDrive { get { return _Is4WheelDrive; }  set { _Is4WheelDrive = value; } }

        public bool IsLifted { get { return _IsLifted; } set { _IsLifted = value; } }

        public Truck() { }

        public Truck(string make, string model, int year, long vinNumber, bool is4WheelDrive, bool isLifted)
        {
            Make = make;
            Model = model;
            Year = year;
            VinNumber = vinNumber;
            Is4WheelDrive = is4WheelDrive;
            IsLifted = isLifted;
        }
    }
}
