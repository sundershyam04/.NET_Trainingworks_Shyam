using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace logic
{
   // public delegate int Arithmeticopr(int a, int b);

    public delegate void Ari(int a, int b);

    //public delegate int Sub(int a, int b);

    //public delegate int Mult(int a, int b);

    //public delegate int Div(int a, int b);


    public class Arithmetic
    {

        public void Addition(int x, int y)
        {
            Console.WriteLine($"Addition : {x+y}");
        }
        public void Subtraction(int x, int y)
        {
            if (x > y)
            {
                Console.WriteLine($"Subtraction : {x - y}");
            }

            else { throw new Exception("x>y"); }
        }

        public void Multiplication(int x, int y)
        {
            Console.WriteLine($"Multiplication : {x*y}");       
        }

        public void Division(int x, int y)
        {
            if (y != 0)
            {

                Console.WriteLine($"Division : {x / y}");
            }
            else { throw new ArithmeticException(); }
        }



    }
}
