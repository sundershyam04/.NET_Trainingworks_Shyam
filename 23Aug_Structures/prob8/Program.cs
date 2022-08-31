using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace prob8
{
    internal class Program
    {

        static void handle(int a, int b)
        {
            try
            {
                int div = a / b;
                Console.WriteLine(div);
            }
            catch (DivideByZeroException e)
            {
                Console.WriteLine($"Message:  {e.Message}");

                Console.WriteLine($"Line   : {e.StackTrace}");
            }
        }
static void Main(string[] args)
        {

            int a = 144;
            int b = 0;
            
            handle(a,b);


           
        }
    }
}
