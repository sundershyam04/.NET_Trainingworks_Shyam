using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExtensionMethods
{
    public abstract class Person
    {
        public abstract void Work();
    }

    public class Manager : Person

    {
        public override void Work()
        {
            Console.WriteLine("Manager - Working");
        }
    }

    public class Employee : Person

    {
        public override void Work()
        {
            Console.WriteLine("Employee - Working");
        }
    }

    public class Clerk : Person

    {
        public override void Work()
        {
            Console.WriteLine("Clerk - Working");
        }
    }


}

