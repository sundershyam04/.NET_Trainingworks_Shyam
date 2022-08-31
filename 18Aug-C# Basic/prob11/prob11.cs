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
            Console.WriteLine("Enter n1 and n2");
            int n1 = int.Parse(Console.ReadLine());
            int n2 = int.Parse(Console.ReadLine());

            bool res = (n1 > 0 && n2 > 0);

            Console.WriteLine(res);


        }
    }
}
