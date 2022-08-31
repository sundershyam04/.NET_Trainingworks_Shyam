using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace dsa_day1
{
    internal class Arrays
    {

        static void Main(string[] args)
        {

            //int[] ar2 = new int[4];//Single Dimension
            //int[,] arr = new int[3, 3];//Multi-dimension/Rectangular Arrays
            // int[][] arr1 = new int[3][];//Jagged
            //9 values
            //arr[0, 1] = 10;
            //arr[1, 2] = 20;
            //arr[2, 0] = 30;
            Console.WriteLine("====Jaggedarray======");
            int [][] arr1 ={

                     new int[] { 1, 2, 3, 4 },
                     new int[] {5,6,7,8},
                     new int[] {9,10,11,12}
            };


            for (int i = 0; i < 3; i++)//Row
            {
                Console.Write('{');
                for (int j = 0; j < arr1[i].Length; j++)
                {
                    Console.Write(arr1[i][j] + "\t");
                }
                Console.WriteLine('}');
                Console.WriteLine();

            }
            Console.WriteLine("===================");
            Console.ReadLine();

        }

    }
}
