using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace prob8
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            for (int j = 1; j <= n; j++)
            {
                for (int i = 1; i <= j; i++)
                {
                    Console.Write('*');
                }
                Console.WriteLine();
            }
        }
    }
}
