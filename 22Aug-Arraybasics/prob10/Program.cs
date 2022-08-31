using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace prob10
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Dictionary<int,string> d = new Dictionary<int,string>();

            d.Add(11, "babu");
            d.Add(2, "Ganesh");
            d.Add(33, "Daya");
            d.Add(4, "Afzal");
            d.Add(53, "Nihal");
            d.Add(6, "Satish");

            foreach (KeyValuePair<int, string> ele in d)
            {
                Console.WriteLine("{0} - {1}",
                          ele.Key, ele.Value);
            }

            Console.ReadLine();
        }
    }
}
