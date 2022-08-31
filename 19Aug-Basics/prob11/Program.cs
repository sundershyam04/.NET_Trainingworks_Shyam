using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace prob11
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int sum = 0, n = 0;
            for(int i = 101; i < 200; i++)
            {
                sum += i;
                n += 1;
            }
            Console.WriteLine($"Sum of {n} integers from 100 to 200 is {sum}");
        }
    }
}
