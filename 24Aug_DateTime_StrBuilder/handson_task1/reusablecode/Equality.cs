using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace reusablecode
{
    public class Equality
    {
        public static void equals(string a, string b)
        {

         bool res= String.Equals(a, b);
            if (res)
            {
                Console.WriteLine($"{a} and {b} are equal");
            }
            else

                Console.WriteLine($"{a} and {b} are not equal");
        }
    }
}
