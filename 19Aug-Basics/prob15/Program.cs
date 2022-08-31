using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace prob15
{
    internal class Program
    {
        static void Main(string[] args)
        {
            for(int i = 0,j=25;; i++, j--)
            {
                if (i > j)
                {
                    Console.WriteLine("================================");
                    Console.WriteLine("crossover!");
                    break;
                }
                Console.WriteLine($" i  : {i}  j  : {j}");
            }
               
        }
    }
}
