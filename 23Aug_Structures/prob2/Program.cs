using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace prob2
{
    internal class Program
    {
        static int add(int a, int b)
        {
            Console.WriteLine("Addition in function");
            return a+b;
        }
           
        static void Main(string[] args)
        {
            int a,b;
            Console.WriteLine("Enter a:");
            a=int.Parse(Console.ReadLine());   
            Console.WriteLine("Enter b:");
            b=int.Parse(Console.ReadLine());
            int sum=add(a,b);   // func call

            Console.WriteLine($"Sum is {sum}");
            Console.Read();
         }
    }
}
