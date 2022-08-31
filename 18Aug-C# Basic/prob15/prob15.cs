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
            Console.Write("Enter currency in USD :$");
            double usd = Convert.ToSingle(Console.ReadLine());

            double inr = usd * 79.93;


            Console.WriteLine($"USD : {usd}");
            Console.WriteLine($"INR : {inr}");
         
        }
    }
}
