using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using reusablecode;
namespace myapp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter a string a: ");
            string a = Console.ReadLine();


            Console.WriteLine("Enter a string b: ");
            string b = Console.ReadLine();
            
            //1
            Equality.equals(a, b);

            Console.WriteLine("============================\n");
            //2
            Copy.copies(a, b);
            Console.WriteLine("============================\n");
            //3
            Indexof.index(a);
            Console.WriteLine("============================\n");
            //4
            Split.split();
            Console.WriteLine("============================\n");
            //5
            Upper.to_up();
            Console.WriteLine("============================\n");
            //6
            reusable_main.createfile();
            Console.WriteLine("============================\n");
            //7
            Day.fn();
            Console.WriteLine("============================\n");

        }
    }
}
