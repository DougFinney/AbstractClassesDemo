using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.PortableExecutable;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleUI
{
    class Program
    {
        static void Main(string[] args)
        {
            /*
             * Todo follow all comments!! 
             */

            #region Vehicles

            /*
             * Create an abstract class called Vehicle..._DONE
             * The vehicle class shall have three string properties Year, Make, and Model...._DONE
             * Set the defaults to something generic in the Vehicle class...._DONE
             * Vehicle shall have an abstract method called DriveAbstract with no implementation.._DONE
             * Vehicle shall have a virtual method called DriveVirtual with a base implementation.,,_DONE
             */

            /* 
             * Now create 2 non-abstract classes: Car..._DONE and Motorcycle..._DONE, that inherit from Vehicle.._DONE
             * Add a distict property in the 2 derived classes such as HasTrunk for Car and HasSideCart for Motorcycle..._DONE
             * Provide the implementations for the abstract methods.._DONE
             * Only in the Motorcycle class will you override the virtual drive method.._DONE
            */

            // Create a list of Vehicle called vehicles
            var vehicles = new List<Vehicle>();

            /*
             * Create 4 instances: 1 Car, 1 Motorcycle, and then 2 instances of type Vehicle (use explicit typing) but use constuctors from derived classes.._DONE
             * 
             * Set the properties with object initializer syntax...._DONE
             */
            var car1 = new Car()
            {
                Year = "2018",
                Make = "Jeep",
                Model = "Wrangler",
                HasTrunk = false
            };

            var moto1 = new Motorcycle()
            { 
                Year = "2012",
                Make = "Harley",
                Model = "Road King",
                HasSideCar = false 
            };

            Vehicle car2 = new Car() 
            { 
                Year = "2015",
                Make = "Chevy",
                Model = "Malibu",
                HasTrunk = true
            };

            Vehicle moto2 = new Motorcycle() 
            { 
                Year = "2023", 
                Make ="Indian", 
                Model = "Chief", 
                HasSideCar = true 
            };

            /*
             * Add the 4 vehicles to the list
             * Using a foreach loop iterate over each of the properties
             */
            vehicles.Add(car1);
            vehicles.Add(moto1);
            vehicles.Add(car2);
            vehicles.Add(moto2);

            // Call each of the drive methods for one car and one motorcycle
            foreach (var vehicle in vehicles)
            {
                Console.WriteLine($"Year: {vehicle.Year}, Make: { vehicle.Make}, Model: { vehicle.Model}");
                vehicle.DriveAbstract();
                vehicle.DriveVirtual();
                Console.WriteLine("--------");
            }

            #endregion            
            Console.ReadLine();
        }
    }
}
