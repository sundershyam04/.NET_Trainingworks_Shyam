using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace reusablecode
{
    public class Copy
    {
        public static void copies(string a, string b)
        {
            string acop, bcop;
            Console.WriteLine($"a    : {a}     | b    : {b}");
            acop = String.Copy(a);
            bcop = String.Copy(b);
            Console.WriteLine($"copy of a: {acop} | copy of b: {bcop}");

        }
    }
}
