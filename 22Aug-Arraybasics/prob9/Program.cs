using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace prob9
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List <float> l = new List <float> ();

            l.Add (11.1f);
            l.Add (21.3f);
            l.Add (34.8f);
            l.Add (5.8f);
            l.Add (57.8f);
            l.Add (608.8f);

            Console.WriteLine("lIST ELEMENTS");
            foreach (var item in l)
            {
                Console.WriteLine(item);
            }

            l.Sort ();
            Console.WriteLine("AFTER SORTING");
            foreach (var item in l)
            {
                Console.WriteLine(item);
            }
            l.Reverse();
            Console.WriteLine("dESC ORDER");

            foreach (var item in l)
            {
                Console.WriteLine(item);
            }
        }
    }
}
