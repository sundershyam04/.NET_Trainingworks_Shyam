using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SortingDemo
{
    internal class Binarysearch
    {
        static void insertion_sort(int[] a, int n)
        {
            for(int i=1; i<n; i++)
            {
                int key = a[i];
                int bef = i - 1;
                while(bef>=0 && a[bef] > key)
                {
                    a[bef + 1] = a[bef];
                    bef--;
                }
                a[bef + 1] = key;
            }

        }

        // binarysearch

        static void binarysrc(int[] a, int i,int j,int e)
        {
            while(i<=j)
            {
                int mid = i + (j-i) / 2;
                if (a[mid] == e)
                {
                    Console.WriteLine($"Element found at index: {mid}");
                    break;
                }

                else if (a[mid] < e)
                {
                    i = mid + 1;
                }
                else if (a[mid] > e)
                {
                    j = mid - 1;
                }
            }

        }
        static void Main(string[] args)
        {
            // < BINARY SEARCH >
            Console.WriteLine("===Binary search===");
           
            int[] a = { 13, 44, 276, 87, 989, 764, 54, 34 };

            foreach (var item in a)
            {
                Console.WriteLine(item);
            }

            insertion_sort(a, a.Length);

            Console.WriteLine("===SORTED ARRAY===");
            foreach (var item in a)
            {
                Console.WriteLine(item);
            }

            Console.WriteLine("Element to search: ");
            int e=int.Parse(Console.ReadLine());
           
            binarysrc(a,0,a.Length-1,e); // binsearch


        }
    }
}
