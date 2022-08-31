using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace prob1
{
    internal class Program
    {  static void add(int a, int b)
        {
            Console.WriteLine($"Addition :{a+b}");
        }
           
        static void Main(string[] args)
        {
            int a,b;
            Console.WriteLine("Enter a:");
            a=int.Parse(Console.ReadLine());   
            Console.WriteLine("Enter b:");
            b=int.Parse(Console.ReadLine());
            add(a,b);   // func call
            Console.Read();
         }
    }
}
