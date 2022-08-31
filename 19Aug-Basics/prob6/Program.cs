using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace prob6
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int year = int.Parse(Console.ReadLine());
            Console.WriteLine($"year  :  {year}");

            if (year % 400 == 0)
            {
                Console.WriteLine($"{year} is a leap year.");
            }
            // not a leap year if divisible by 100
            // but not divisible by 400
            else if (year % 100 == 0)
            {
                Console.WriteLine($"{year} is not a leap year.");
            }
            // leap year if not divisible by 100
            // but divisible by 4
            else if (year % 4 == 0)
            {
                Console.WriteLine($"{year} is a leap year.");
            }
            // all other years are not leap years
            else
            {
                Console.WriteLine($"{year} is not a leap year.");
            }

        }
    }
}
