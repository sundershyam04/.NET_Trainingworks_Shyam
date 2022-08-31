using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int sum = 0;
            Console.WriteLine("Numbers between 100 and 200, divisible by 9 :");
            for (int i = 100; i <= 200; i++)
            {
                if(i%9 == 0)
                {
                    Console.WriteLine(i);
                    sum += i;
                }
            }
            Console.WriteLine("==============================");
            Console.WriteLine($"Sum :{sum}");

        }
    }
}
