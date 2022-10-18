using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SpecFlowBasic
{
    public class CalculatorApp
    {

        public int Add(int a,int b)
        {

            return a + b;
        }

        public int Subtract(int a, int b)
        {

            return a - b;
        }

        public int Multiply(int a, int b)
        {

            return a * b;
        }

        public int Divide(int a, int b)
        {

            return b != 0 ? a / b : 0;
        }

        public double Sqrroot(double a)
        {

            return a!=0 ? Math.Sqrt(a) : 0;
        }
    }
}
