using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace reusablecode
{
    public class Split
    {

        public static void split()
        {
            Console.WriteLine("Split example");
            Console.WriteLine("Enter a string: ");
            string s=Console.ReadLine();
            string[] sp = s.Split('#');
            Console.WriteLine("Splitted string");
            Console.WriteLine("-------------------------");
            foreach (string s2 in sp)
            {
                Console.WriteLine(s2);
            }
            Console.WriteLine("-------------------------");


        }
    }
}
