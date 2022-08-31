using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace prob9
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //n terms of odd natural number and their sum.

            int n = int.Parse(Console.ReadLine());
            Console.WriteLine($"n : {n}");
            int sum = 0;
            //for(int i = 1; i <=n; i++)
            //{
            //    if (i % 2 != 0)
            //    {
            //        Console.WriteLine(i);
            //        sum += i;
            //    }

            //}
            int i = 1;
            int num = 1;
            while (i <= n)
            {
                if( num%2 != 0)         // track natural num : num //  i : no of odd numbers
                {
                    Console.WriteLine(num);
                    sum += num;
                    i++;
                }
                num++;
            }

            Console.WriteLine($"Sum of {n} odd numbers : {sum}");

        }
    }
}
