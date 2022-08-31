using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace prob4
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string s1=Console.ReadLine();
            string s2=Console.ReadLine();

            if (s1 == s2)
                Console.WriteLine("s1 is equal to s2");           
            else
                Console.WriteLine("s1 and s2 are not equal");
        }
    }
}
