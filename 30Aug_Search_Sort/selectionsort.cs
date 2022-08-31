using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SortingDemo
{
    internal class selectionsort
    {
        static void Main(string[] args)
        {

            // < SELECTION SORT >
            Console.WriteLine("SELECTION SORT");
            int[] arr = { 8, 2, 5, 3, 6, 9, 4 };
            Console.WriteLine("===ARRAY===");

            foreach (var item in arr)
            {
                Console.WriteLine(item);
            }

            for (int i=0; i<arr.Length-1; i++)
            {
                int min = i;
                for(int j=i+1; j<arr.Length; j++)
                {
                    if(arr[j] < arr[min])
                    {
                        min = j;
                    }

                }
                if (min != i)    //swap if min element other than min=i
                {
                    int temp = arr[i];
                    arr[i] = arr[min];
                    arr[min] = temp;    

                }
            }

            Console.WriteLine("===SORTED ARRAY===");
            foreach (var item in arr)
            {
                Console.WriteLine(item);
            }
        }
    }
}
