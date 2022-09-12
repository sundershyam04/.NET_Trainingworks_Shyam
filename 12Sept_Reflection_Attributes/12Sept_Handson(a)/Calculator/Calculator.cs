using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calculator
{
    public class Calculator
    {
        public double Number { get;  set; }

        public void Accept (double d)
        {

            Number = d;
        }

        public void  Cube()
        {

             double cubenum = Number * Number * Number;

            Console.WriteLine($"Cube of {Number} is : {cubenum}");

        }

        public void Sqrt()
        {

            double sqrtnum = Math.Sqrt(Number);

            Console.WriteLine($"Square root of {Number} is : {sqrtnum}");

        }

    }
}
