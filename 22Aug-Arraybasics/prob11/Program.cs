using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace prob11
{
    internal class Program
    {
        static void Main(string[] args)
        {
           
            SortedList<int, string> sl = new SortedList<int, string>();
            sl.Add(14, "babu");
            sl.Add(2, "Ganesh");
            sl.Add(34, "Daya");
            sl.Add(4, "Afzal");
            sl.Add(5, "Nihal");
            sl.Add(1, "Satish");

            foreach (KeyValuePair<int, string> ele in sl)
            {
                Console.WriteLine("{0} - {1}",
                          ele.Key, ele.Value);
            }
        }
    }
}
