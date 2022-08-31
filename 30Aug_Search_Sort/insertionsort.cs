using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SortingDemo
{
    internal class insertionsort
    {


        static void insertion_sort(int[] A,int n)
        {

            for(int i = 1; i < n; i++)
            {
                int key=A[i];
                int bef = i - 1;

                while(bef >= 0 && A[bef] > key)
                {
                    A[bef + 1] = A[bef];
                    bef--;
                }
                A[bef+1]=key;
            }

        }

        static void Main(string[] args)
        {
            Console.WriteLine("INSERTION SORT");
            int[] A = { 18, 7, 9, 4, 5, 8, 2,1,50, 3, 11 };

            Console.WriteLine("===ARRAY===");

            foreach (var item in A)
            {
                Console.WriteLine(item);
            }

            insertion_sort(A, A.Length);

            Console.WriteLine("===SORTED ARRAY===");
            foreach (var item in A)
            {
                Console.WriteLine(item);
            }
        }
    }
}
