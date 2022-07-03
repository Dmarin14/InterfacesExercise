using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InterfacesExercise
{
    public interface IVehicle
    {
       string Make { get; set; }

       string Model { get; set; }

       int Year { get; set; }

       long VinNumber { get; set; }
    }
}
