using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _1Sept_Sorting
{
    internal class ShellSort
    {
        static public void swap(ref int a, ref int b)
        {
            int temp = a;
            a = b; 
            b= temp;    

        }
        public static void shell_sort(int[] a)
        {
            int n=a.Length;

            for(int gap = n / 2; gap >= 1; gap = gap /2)
            {//to determine gap or interval 
                for(int j=gap; j<n; j++)
                {
                    for(int i=j-gap; i>=0; i = i - gap)
                    {
                        if (a[i+gap] > a[i])
                        {
                        break;
                        }
                        else
                        {
                            swap(ref a[i + gap], ref a[i]);
                        }
                    }

                }

            }



        }
        static void Main(string[] args)
        {
            // < SHELL SORT >

            int[] a = { 33, 88, 55, 4, 22, 99, 2, 9, 8, 6, 5 };

            //before sort

            Console.WriteLine("===Array before sorting===");

            foreach (var item in a)
            {
                Console.WriteLine(item);
            }

            shell_sort(a);

            //after sort

            Console.WriteLine("===Array after sorting===");

            foreach (var item in a)
            {
                Console.WriteLine(item);
            }

        }
    }
}
