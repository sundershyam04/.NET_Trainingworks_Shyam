using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace logic
{
    // DELIGATE DECLARATION
    public delegate int lendeligate(string s);

    public delegate void Greet(string s);
    public class Strings
    {

        public int getlenth(string s)
        {

            return s.Length;
        }

        public void greetuser(string s)
        {
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.WriteLine($"Hello {s}!!!!!........");
            Console.ForegroundColor = ConsoleColor.White;
        }
    }
}
