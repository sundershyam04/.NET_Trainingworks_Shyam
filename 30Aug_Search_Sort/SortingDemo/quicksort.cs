using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SortingDemo
{
    internal class quicksort
    { 
        //1
        private static void quick_sort(int[] arr, int start, int end)
        {
            if (start < end)
            {
                int p = makePart(arr, start, end);
                quick_sort(arr, start, p - 1);
                quick_sort(arr, p + 1, end);

            }

        }
        //2
        private static int makePart(int[] arr, int start, int end)
        {
            //throw new NotImplementedException();
            int pivot = arr[end];

            int i = (start-1);

            for (int j = start; j <= end - 1; j++)
            {
                if (arr[j] < pivot)
                {
                    i++;
                    int temp1 = arr[i];
                    arr[i] = arr[j];
                    arr[j] = temp1;

                }
            }
            int temp = arr[i + 1];
            arr[i + 1] = arr[end];
            arr[end] = temp;
            return (i + 1);
        }
        static void Main(string[] args)
        {
            // <quick sort>
            Console.WriteLine("< QUICK  SORT > ");
            int[] A = { 250,18, 7, 9, 4, 5, 8, 2, 1, 50, 3, 11 };

            Console.WriteLine("===ARRAY===");

            foreach (var item in A)
            {
                Console.WriteLine(item);
            }

            quick_sort(A, 0,A.Length-1);  //sort

            Console.WriteLine("===SORTED ARRAY===");
            foreach (var item in A)
            {
                Console.WriteLine(item);
            }
        }
    }
}
