using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace prob5
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[][] jag = new int[5][]

            {
                new int[] {201,50},
                new int[] {202,58},
                new int[] {203,62},
                new int[] {204,40},
                new int[] {205,35}
            };

            Console.WriteLine("Jagged array elements:");
            Console.WriteLine("Classroom  Students");
            foreach (var item in jag)
            {
                foreach (var b in item)
                {
                    Console.Write($"{b}\t | \t");
                }
                Console.WriteLine('\n');
            }

        }
    }
}
