using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _18Aug_qn5to_8
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //5 - Arith opr
            int x, y, z;
            x = Convert.ToInt32(Console.ReadLine());
            y = Convert.ToInt32(Console.ReadLine());
            z = Convert.ToInt32(Console.ReadLine());

            int res1 = (x + y) * z;
            int res2 = (x * y) + (y * z);
            Console.WriteLine($"(x + y) * z : {res1}");
            Console.WriteLine($"(x * y) + (y * z) : {res2}");
            //6
            int age;
            age = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine($"You look older than {age}");

           // 7
            int num;
            num = Convert.ToInt32(Console.ReadLine());

            for (int j = 0; j < 4; j++)
            {
                for (int k = 0; k < 4; k++)
                {
                    Console.Write(num);
                    if (j % 2 == 0)
                    {
                        Console.Write(" ");
                    }
                }
                Console.WriteLine('\n');

            }

            //8
            Console.WriteLine("rectangle pattern");
            int row, col;

            row = Convert.ToInt32(Console.ReadLine());
            col = Convert.ToInt32(Console.ReadLine());

            void rect(int m, int n)
            {
                for (int k = 0; k < m; k++)
                {
                    for (int j = 0; j < n; j++)
                    {
                        if ((k != (m - 1) && k != 0) && (j == 1))
                        {
                            Console.Write(" ");
                            continue;
                        }
                        Console.Write(num);
                    }
                    Console.WriteLine('\n');
                }

            }

            rect(row, col);

            //9
            Console.Write("Enter the Temperature :");
            double temperature = Convert.ToSingle(Console.ReadLine());

            double kelvin = temperature + 273.15;

            double Fah = (temperature * 9 / 5) + 32;

            Console.WriteLine($"Celsius : {temperature}");
            Console.WriteLine($"Kelvin : {kelvin}");
            Console.WriteLine($"Fahrenheit : {Fah}");

          












        }
    }
}
