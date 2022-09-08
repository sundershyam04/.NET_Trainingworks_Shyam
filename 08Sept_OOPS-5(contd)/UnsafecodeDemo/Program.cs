using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UnsafecodeDemo
{  
    internal class Program
    {
        static void Main(string[] args)
        {
            // unsafe code - demo
            Console.ForegroundColor=ConsoleColor.Green;
            Console.WriteLine("UNSAFE DEMO\n");
            Console.ForegroundColor = ConsoleColor.White;

            unsafe
            {
                int a=90;
                int b;

                int* ptr=&a;    //  ptr --> a |10| 1178595

                Console.WriteLine($"Address of a using &a  : {(int)&a}");
                Console.WriteLine($"Address of a using ptr : {(int)ptr}");
                Console.WriteLine($"Value at a : {*ptr}");
                
            }

            Console.WriteLine("------------------------------------------");
        }
    }
}
