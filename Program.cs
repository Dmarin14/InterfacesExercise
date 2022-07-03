using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InterfacesExercise
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //TODO Be sure to follow BEST PRACTICES when creating classes and interfaces

            //Create 2 Interfaces called IVehicle & ICompany

            //Create 3 classes called Car , Truck , & SUV

            //In your IVehicle

            /* Create 4 members that Car, Truck, & SUV all have in common.
             * Example: All vehicles have a number of wheels... for now..
             */


            //In ICompany

            /*Create 2 members that are specific to each every company
             * regardless of vehicle type.
             *
             *
             * Example: public string Logo { get; set; }
             */

            //In each of your car, truck, and suv classes

            /*Create 2 members that are specific to each class
             * Example: truck has a bed size while car has a trunk while suv has a cargo hold size
             *
             * Then, Set each class to inherit from both IVehicle and ICompany and implement their members.
             * 
             */

            //Now, create objects of your 3 classes and give their members values;

            var vehicles = new List<IVehicle>();

            Car car = new Car("honda", "Civic", 2020, 123546789, "White", 120);

            Truck truck = new Truck("Toyota", "Tacoma", 2020, 126789412, true, true);

            SUV sUV = new SUV("GMC", "SUV", 2023, 987643484, 8, true);

            vehicles.Add(car);
            vehicles.Add(truck);
            vehicles.Add(sUV);

            foreach (var vehicle in vehicles)
            {
                Console.WriteLine($"{vehicle.Make}  {vehicle.Model}  {vehicle.Year}  {vehicle.VinNumber}");
            }

            Console.ReadLine();

          
           
            //Creatively display and organize their values

            
        }
    }
}
