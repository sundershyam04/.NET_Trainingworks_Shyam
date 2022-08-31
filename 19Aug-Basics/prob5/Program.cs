using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace prob5
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int a=int.Parse(Console.ReadLine());
            int b=int.Parse(Console.ReadLine());

            if (a > b)
            {
                Console.WriteLine($"{a} is biggest");
            }
            else
            {
                Console.WriteLine($"{b} is biggest");
            }
        }
    }
}
