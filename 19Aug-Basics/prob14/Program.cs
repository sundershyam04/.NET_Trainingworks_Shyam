using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace prob14
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("enter a number:");
            int num = int.Parse(Console.ReadLine());
            bool iseven = num % 2 == 0;
            bool isodd = num % 2 != 0;
            bool islarge = num > 100;
            bool iszero = num == 0;
            Console.WriteLine("=============================================");
            Console.WriteLine("1 for even check \n2 for oddcheck \n" +
                              "3 for largenumber check \n4 for zero check");
            Console.WriteLine("=============================================");
            for (int i = 1; i <= 4; i++)
            {
                
                int action = int.Parse(Console.ReadLine());
                switch (action)
                {

                    case 1: Console.WriteLine(iseven); break;
                    case 2: Console.WriteLine(isodd); break;
                    case 3: Console.WriteLine(islarge); break;
                    case 4: Console.WriteLine(iszero); break;
                }
            }
        }
    }
}
