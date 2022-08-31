
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
            int[] arr = new int[] { 1, 3, 5, 200, 22, 2244, 213, 111 };
            int count = 0;

            foreach (var item in arr)
            {
                if (item > 100) count++;

            }

            Console.WriteLine($"No.of.elements greater than 100 : {count}");
             
        }
    }
}
