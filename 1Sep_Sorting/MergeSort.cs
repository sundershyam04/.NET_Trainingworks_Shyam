using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _1Sept_Sorting
{
    internal class MergeSort
    {

        //2
        public static void merge(int[] a,int l,int m,int h)
        {
            int ln = m - l + 1;
            int[] L = new int[ln];

            int rn = h-m;

            int[] R = new int[rn];



            for(int i2 = 0; i2 < ln; i2++)
            {
                L[i2] = a[l+i2];

            }
            for (int j2 = 0; j2 < rn; j2++)
            {
                R[j2] = a[m+1+j2];

            }

            int i = 0;
            int j = 0;
            int k = l;

            while (i<ln && j<rn)
            {
                if (L[i] <= R[j])
                {
                    a[k] = L[i];  
                    i++;
                }
                else
                {
                    a[k] = R[j];
                    j++;
                }
                k++;
            }

           
           while (i < ln)
             {
                a[k]=L[i];
                i++;k++;
             }

            while (j < rn)
            {
                a[k] = R[j];
                j++; 
                k++;
            }

        }


        static public void merge_sort(int[] a,int l,int h) 
        {

            if (l < h)
            {
                int mid = (l + h) / 2;

                merge_sort(a, l, mid);
                merge_sort(a, mid + 1, h);
                merge(a, l, mid, h);
            }         
        }
        static void Main(string[] args)
        {
            // < MERGE SORT>
            Console.WriteLine("MERGE SORT");

            int[] a = { 33, 88, 55, 4, 22, 99, 2, 9, 8854, 6, 5 ,5841};

            //before sort

            Console.WriteLine("===Array before sorting===");

            foreach (var item in a)
            {
                Console.WriteLine(item);
            }

            merge_sort(a,0,a.Length-1);

            //after sort

            Console.WriteLine("===Array after sorting===");

            foreach (var item in a)
            {
                Console.WriteLine(item);
            }
            Console.ReadLine();
        }
    }
}
