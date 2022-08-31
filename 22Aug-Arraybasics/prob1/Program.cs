using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace prob1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] arr = new int[10];

            for(int i = 0; i < arr.Length; i++)
            {
                Console.Write($"arr[{i}] :");
                arr[i]=Convert.ToInt32(Console.ReadLine());
            }
            Console.WriteLine("ELEMENTS IN THE ARRAY");
            foreach (var item in arr)
            {
                Console.Write($"{item}  ");
            }
        
        }
    }
}
