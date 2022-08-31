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

            Console.Write("Enter the Temperature in celsius :");
            double temperature = Convert.ToSingle(Console.ReadLine());
            double Fah = (temperature * 9 / 5) + 32;

            Console.WriteLine("=========================");

            Console.WriteLine($"Celsius : {temperature}");
            Console.WriteLine($"Fahrenheit : {Fah}");
        }
    }
}
