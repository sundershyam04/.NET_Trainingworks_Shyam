using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace prob15
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Console.WriteLine("Enter number of elements in array");
            //int n = int.Parse(Console.ReadLine());
            //int[] arr = new int[n];

            //for(int i = 0; i < n; i++)
            //{
            //    arr[i] =int.Parse(Console.ReadLine());
            //}

            //Dictionary<int, int> map = new Dictionary<int, int>();
            //int[] a = new int[n];

            //Array.Copy(arr, a, n);

            ////foreach (var item in arr)
            ////{
            ////    Console.WriteLine(item);
            ////}

            //Array.Sort(a);

            //int cnt=0;

            //for(int i=0;i<n-1;i++)
            //{
            //    for(int j = i + 1; j < n; j++)
            //    {
            //        if (a[i] == a[j]) {
            //            cnt++;
            //        }            

            //    }
            //    map[a[i]] = cnt;
            //    cnt = 0;
            //}

            //foreach (KeyValuePair<int, int> ele1 in map)
            //{
            //    Console.WriteLine("{0} and {1}",
            //              ele1.Key, ele1.Value);
            //}

            //for (int k=0;k<n;k++)
            //{
            //  if( map[arr[k]] > 1)
            //    {
            //        Console.WriteLine($"Postion of the first repeated value: {k+1}\nElEMENT : {arr[k]}");   
            //    }
            //}
            int n = int.Parse(Console.ReadLine());
            int[] arr = new int[n];

            for (int i = 0; i < n; i++)
            {
                arr[i] = int.Parse(Console.ReadLine());
            }
            int cnt = 0;
            for(int i= 0; i < n; i++)
            {
                for(int j = 0; j < n; j++)
                {
                    if (arr[i] == arr[j]) { cnt += 1; }

                }
                if(cnt >= 2)
                {
                    Console.WriteLine($"Postion of the first repeated value: {i+1}\nElEMENT : {arr[i]}");
                    break;
                }
                cnt = 0;
            }
            Console.ReadLine();

        }
    }
}
