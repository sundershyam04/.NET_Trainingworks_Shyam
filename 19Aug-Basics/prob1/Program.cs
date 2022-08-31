using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace prob1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int a = int.Parse (Console.ReadLine());
            int b = int.Parse (Console.ReadLine());

            if (a > b)
            {
                Console.WriteLine($"Maximum Number : {a}");
                Console.WriteLine($"Minimum Number : {b}");
            }
            else
            {
                Console.WriteLine($"Maximum Number : {b}");
                Console.WriteLine($"Minimum Number : {a}");
            }
        }
    }
}
