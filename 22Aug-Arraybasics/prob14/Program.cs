﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace prob14
{
    internal class Program
    {
            static int ways(int[] S, int m, int n)
            {
                if (n == 0)
                    return 1;

                if (n < 0)
                    return 0;

                if (m <= 0)
                    return 0;


                return ways(S, m - 1, n) +
                    ways(S, m, n - S[m - 1]);
            }
            public static void Main()
            {
                Console.Write("n = ");
                int n = Convert.ToInt32(Console.ReadLine());
                Console.Write("m = ");
                int m = Convert.ToInt32(Console.ReadLine());
                Console.Write("arr = ");
                int[] arr = new int[n];
                var stringArray = Console.ReadLine().Split(' ');
                for (var i = 0; i < m; i++)
                {
                    arr[i] = int.Parse(stringArray[i]);
                }
                Console.WriteLine("Output = {0}", ways(arr, m, n));
                Console.ReadLine();
            }
    }
}
