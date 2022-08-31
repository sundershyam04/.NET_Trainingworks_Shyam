using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace prob12
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter a string");
            string str = Console.ReadLine();

            Console.WriteLine($"{str} is null??");
            Console.WriteLine(String.IsNullOrEmpty(str));
        }
    }
}
