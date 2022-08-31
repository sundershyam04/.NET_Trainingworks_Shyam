using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace arraysdemo
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double[] d = { 2.3, 45.6, 78.8, 90.8 };
            Console.WriteLine("=======using for=======");
            for (int i=0; i<d.Length; i++)
            {
                Console.WriteLine(d[i]); ;
            }
            Console.WriteLine("=======using foreach=====");
            foreach(var n in d)
            {
                Console.WriteLine(n);
            }
            Console.WriteLine("==============");
            int[] a = new int[4];
            a[0] = 1;
            a[1] = 2;
            foreach (var item in a)
            {
                Console.WriteLine(item);
            }

            Console.WriteLine("=====create instance method=========");

            Array arr=Array.CreateInstance(typeof(int),5);

            int[] rar =(int[])arr;
            
            rar[0] = 100;
            rar[1] = 2000; 
            rar[2] = 32;
            rar[3] = 4985;
            rar[4] = 78;

            foreach (var item in rar)
            {
                Console.WriteLine(item);
            }
            
            Console.WriteLine("=====Sorted array- asc=========");
            Array.Sort(rar);
            foreach (var item in rar)
            {
                Console.WriteLine(item);
            }
            Console.WriteLine("=====Desc=========");
            Array.Reverse(rar);
            foreach (var g in rar)
            {
                Console.WriteLine(g);
            }
            Console.WriteLine("==============");

            int[] prices = new int[]{10,20,30,22,45,567,89};
            int[] prices_copy = new int[prices.Length];

            Array.Copy(prices, prices_copy, prices.Length);
            Console.WriteLine("=====Copied array=====");

            foreach (var item in prices_copy)
            {
                Console.WriteLine(item);
            }

            Console.WriteLine("=====clear array=====");

            Array.Clear(prices, 0, prices.Length);
            foreach (var item in prices)
            {
                Console.WriteLine(item);
            }

           Console.WriteLine("==============");











            Console.ReadLine();
        }
    }
}
