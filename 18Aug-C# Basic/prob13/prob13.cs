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
            Console.WriteLine("Enter distance in metre:");
            double metre = double.Parse(Console.ReadLine());

            double km = metre / 1000;
            Console.WriteLine($"Distance in km: {km}" + "km");

            Console.WriteLine("===============================");

            Console.WriteLine("Enter distance in km:");
            double kmetre = double.Parse(Console.ReadLine());

            double met = kmetre * 1000;
            Console.WriteLine($"Distance in m: {met}" + "m");




        }
    }
}
