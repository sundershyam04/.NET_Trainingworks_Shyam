using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2Sep_OOPS_1
{
    internal class Car
    {

        public Car()   // CONSTRUCTOR
        {
            Console.WriteLine("object created for car");
        }
         // PUBLIC PROPERTIES

        public int Model{ get; set; }
        public string Name { get; set; }
        public int Maxspeed{ get; set; }

        public float avgsp { get; private set; }
        
        
        public void run(float avgsp)
        {
            Console.WriteLine($"My avg speed: {avgsp}");

            this.avgsp = avgsp;
        }

        public void showdetails()
        {
            Console.WriteLine($"Model    : {Model}");
            Console.WriteLine($"Name     : {Name}");
            Console.WriteLine($"Maxspeed : {Maxspeed}");
            Console.WriteLine($"Avgspeed : {avgsp}");

        }

        ~Car()
        {
            Console.WriteLine("===============================");
            Console.WriteLine("OBJECT DESTROYED");
            Console.WriteLine("===============================");
        }
    }
}
