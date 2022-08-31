using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
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
            Console.WriteLine("elements of array: ");
            foreach (var item in arr)
            {
                Console.WriteLine(item);
            }


            Console.WriteLine("elements of array in Reverse order: ");
            Array.Reverse(arr);
            foreach (var item in arr)
            {
                Console.WriteLine(item);
            }

        }
    }
}
