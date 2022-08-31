using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _19Aug_Practise
{



    internal class Program
    {
        static void Main(string[] args)
        {
            //prob 2

            int num1, num2, num3;
            
            num1 = 1;
            num2 = 280;
            num3 = 50;
            if (num1 > num2)
            {
                if (num1 > num3)
                {
                    Console.Write($"Maximum number: {num1}");
                }
                else
                {
                    Console.Write($"Maximum number: {num3}");
                }
            }
            else if (num2 > num3)
                Console.Write($"Maximum number: {num2}");
            else
                Console.Write($"Maximum number: {num3}");

          Console.WriteLine('\n');
        }
        
    }
}
