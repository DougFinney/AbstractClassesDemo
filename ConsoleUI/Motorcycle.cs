using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleUI
{
    public class Motorcycle : Vehicle
    {
        public Motorcycle()
        {

        }

        public bool HasSideCar { get; set; } = true;
        public override void DriveAbstract()
        { 
          Console.WriteLine($"This {GetType().Name} is in drive abstractly.");
        }

        public override void DriveVirtual()
        {
              Console.WriteLine($"This {GetType().Name} is as {GetType().BaseType.Name} has a hand throttle");     
        }
    }
}
