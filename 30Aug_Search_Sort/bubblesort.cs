using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml;

namespace SortingDemo
{
    internal class bubblesort
    {
        static void bubble_sort(int[] A, int n)
        {
            int temp;
            for (int k = 0; k < n - 1; k++)
            {
                // (n-k-1) is for ignoring comparisons of elements which have already been compared in earlier iterations

                for (int i = 0; i < n - k - 1; i++)
                {
                    if (A[i] > A[i + 1])
                    {
                        // here swapping of positions is being done.
                        temp = A[i];
                        A[i] = A[i + 1];
                        A[i + 1] = temp;
                    }
                }
            }
        }
        static void Main(string[] args)
        {
            // < BUBBLE SORT >

            Console.WriteLine("BUBBLE SORT");
            int[] A = { 8, 7, 9, 4, 5, 8, 2, 3, 11 };

            Console.WriteLine("===ARRAY===");

            foreach (var item in A)
            {
                Console.WriteLine(item);
            }

            bubble_sort(A, A.Length);

            Console.WriteLine("===SORTED ARRAY===");
            foreach (var item in A)
            {
                Console.WriteLine(item);
            }

        }
    }
}
