using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace prob10
{
    internal class Program
    {
        static void Main(string[] args)
        {

            //Reverse of a number 
            int i=int.Parse(Console.ReadLine());
            Console.WriteLine(i);

            int rev= 0;
            while (i > 0)
            {
                int rem = i % 10;
                rev= (rev * 10) + rem;
                i = (int)i/10;
            }

            Console.WriteLine(rev);
        }
    }
}
