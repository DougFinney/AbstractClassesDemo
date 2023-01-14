using Microsoft.VisualBasic;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleUI
{
    public abstract class Vehicle
    {

        public string Year { get; set; } = "2000";
        public string Make { get; set; } = "Default Make";
        public string Model { get; set; } = "Default Model";

        //stubbed out method  
        public abstract void DriveAbstract();

        public virtual void DriveVirtual() 
        {
            Console.WriteLine($"This {GetType().Name} is virtually driving.\n");
            
        }
    }
    
}
