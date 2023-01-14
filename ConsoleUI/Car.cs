using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleUI
{
    public class Car : Vehicle
    {
        //default constructor
        public Car()
        {
        }
        public bool HasTrunk { get; set; } = false;

        public override void DriveAbstract()
        {
            Console.WriteLine($"This {GetType().Name} is in drive abstractly.");
        }

        

    }
}
