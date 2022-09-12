using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MathsLogic
{
    public class Add
    {
        public string Name { get; set; }
        public string Description { get; set; }
        public void Acceptdata(string s,string  d)
        {
            Name = s;
            Description = d;

        }

        public void Displaydata()
        {
            Console.WriteLine(Name);
            Console.WriteLine(Description);

        }


        public static double add(double x, double y)
        {
            return x + y;
        }
    }
}
