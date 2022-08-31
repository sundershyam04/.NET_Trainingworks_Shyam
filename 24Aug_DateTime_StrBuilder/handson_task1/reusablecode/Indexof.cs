using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace reusablecode
{
    public class Indexof
    {
        public static void index(string str)
        {
            int i = str.IndexOf('m');
            Console.WriteLine($"Index of 'm' in {str} is {i}");

        }
    }
}
