using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace prob13
{
    internal class Program
    {
        static void Main(string[] args)
        {

            Console.WriteLine("Enter a number: ");
            int num = int.Parse(Console.ReadLine());

            if (num == 0)
                Console.WriteLine("num is zero");
            else 
            {
                if (num > 100) Console.WriteLine("num is very large");
                else
                {
                    if (num % 2 == 0) {
                                 Console.WriteLine("num is even");
                                 if (num % 10 == 0) Console.WriteLine("num is multiple of 10");
                    }

                    else {

                        Console.WriteLine("num is odd");
                        if (num % 10 == 0) Console.WriteLine("num is multiple of 10"); }

                }

            }
        }
    }
}

