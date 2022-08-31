using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace prob7
{
    internal class Program
    {
        static void Main(string[] args)
        {

            int a = 9;
            int b = 0;
            int div;


            try
            {
                div = a / b;
                Console.WriteLine(div);
            }
            catch (DivideByZeroException e)
            {
                Console.WriteLine($"Message:  {e.Message}" );

                Console.WriteLine($"Line   : {e.StackTrace}");
            }
        }
    }
}
