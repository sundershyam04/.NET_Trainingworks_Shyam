using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace prob3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int n;
            Console.WriteLine("Enter number of elements in array :");
            n = int.Parse(Console.ReadLine());

            int[] arr = new int[n];

            for (int i = 0; i < n; i++)
            {
                Console.Write($"arr[{i}] :");
                arr[i] = int.Parse(Console.ReadLine());
            }
            var sum = 0;
            foreach (var item in arr)
            {
                sum += item;
            }
            Console.WriteLine($"Sum of all elements in array is {sum}");
        }
    }
}
