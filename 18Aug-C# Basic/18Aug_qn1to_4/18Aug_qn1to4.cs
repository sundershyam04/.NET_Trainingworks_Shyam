using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Csharp_basics_18Aug_
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int a,b;
            Console.WriteLine("enter a:");
            a = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("enter b:");
            b= Convert.ToInt32(Console.ReadLine());
            //call by value
             void swapval(int x, int y)
            {
                int temp = x;
                x = y; y = temp;
                
            }
            //call by reference

            void swapref(ref int x, ref int y)
            {
                int temp = x;
                x = y;
                y = temp;
            }
            swapval(a, b);
            Console.WriteLine($"Swapbyvalue: \n a :{a}   b : {b}");
            
            swapref(ref a, ref b);
            Console.WriteLine($"Swapbyreference \n a:{a}   b : {b}");
            Console.WriteLine("-------------------------------------------");

            //qn2- MUltiplication of 3 numbers
            int p, q, r,s;
            Console.WriteLine("enter p:");
            p = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("enter q:");
            q = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("enter r:");
            r = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("enter s:");
            s = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine($"{p} * {q} * {r} = {p*q*r}");
            Console.WriteLine("-------------------------------------------");

            //Qn3- arithmetic operation

            Console.WriteLine($"Addition : {p + q + r}");
            Console.WriteLine($"Subtraction : {p - q - r}");
            Console.WriteLine($"Division of p by q : {p/q}");

            //qn4 -Average of 4 nos
            Console.WriteLine($"Average of p q r s:  {((p + q + r + s)/ 4)}");

        }
    }
}
