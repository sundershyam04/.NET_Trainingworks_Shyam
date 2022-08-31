using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/*
 Source : Shyam
 Date   : Aug 17,2022
 Topic  : C# Arrays | Strings - Concatenation

*/

namespace Arrays
{
    internal class Program
    {

       
        static void Main(string[] args)
        {
                                //  Arrays

            int[] arr =new int[] {10,25,30,45,50};
            int n = arr.Length;
            Console.WriteLine($"length of arr is {n}");

            // interpolation using '$'

            foreach (int i in arr)
            {
                Console.WriteLine(i);
            }

            // arr elements increment by a 

            void inc(int[] i, int a)

            {
                Console.WriteLine($"arr elements increment by {a}\n");
                for (int j = 0; j < i.Length; j++)
                {
                    Console.WriteLine($"arr[{j}] + {a} : { i[j]+ a }");
                }
                Console.WriteLine('\n');
            }

            inc(arr,5); 
            inc(arr,10);
            inc(arr,1);


            Console.WriteLine("------------------------------------------");

                                // Strings

            string[] str = { "Ramesh", "Suresh", "Ganesh", "Priya", "Ramya" };
            Console.WriteLine($"Length of str is {str.Length}");
             
            // Uppercase

            Console.WriteLine("uppercase\n");
            foreach (string s in str)
            {
                Console.WriteLine(s.ToUpper());
            }
            
            // Lowercase

            void lowcase(string[] a)
            {
                Console.WriteLine("lowercase\n");
                foreach (string s in a)
                {
                    Console.WriteLine(s.ToLower());
                }

            }

            lowcase(str);
            Console.WriteLine("-----------------------------");

                                    //      New string - Concatenation opr

            string[] mobiles = new string[3];

            Console.WriteLine("Enter mobile array contents:");

            // String i/p from user
            
            for (int j=0; j < mobiles.Length; j++)
            {
                mobiles[j] =Console.ReadLine();
            }

            // Printing contents

            Console.WriteLine("\nContents in mobiles array \n");

            foreach (string s in mobiles)
            {
                Console.WriteLine(s);
            }

            Console.WriteLine('\n');

            //Print hello fn

            string hh = "Hello ";

            void hello(string hs)
            {
                Console.WriteLine( hh + hs +"!! ");
            }


            hello(mobiles[0]);
            hello(mobiles[1]);

            Console.WriteLine($"{string.Concat(hh, mobiles[2])}!! ");


        }
    }
}
