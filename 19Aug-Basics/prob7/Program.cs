using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Schema;

namespace prob7
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int mark1 = int.Parse(Console.ReadLine());
            int mark2 = int.Parse(Console.ReadLine());
            int mark3 = int.Parse(Console.ReadLine());
            Console.WriteLine($"mark1 :{mark1} \nmark2 :{mark2} \nmark3 : {mark3}");
            int total= 0;
            int avg;

            total = mark1 + mark2 + mark3;

            avg = total / 3;
            Console.WriteLine("=============================================");
            if (avg < 35)
                Console.WriteLine($"avg : {avg} \n  Result : Fail");
            else if (avg >= 35 && avg < 45)
                Console.WriteLine($"avg : {avg}     Result : Third");
            else if (avg >= 45 && avg < 60)
                Console.WriteLine($"avg : {avg}     Result : Second");
            else
                Console.WriteLine($"avg : {avg}     Result : First");
            Console.WriteLine("=============================================");
        }
    }
}
