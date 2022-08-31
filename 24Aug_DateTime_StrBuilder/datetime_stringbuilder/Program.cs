using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace practicedemo
{
    internal class Program
    {
        static void Main(string[] args)
        {

            //DateTime bdate;

            //DateTime Today=DateTime.Now;

            //Console.WriteLine("enter DOB");

            //bdate = DateTime.Parse(Console.ReadLine());



            //int age = Today.Year - bdate.Year;

            //int doy = bdate.DayOfYear;

            //DayOfWeek dow = bdate.DayOfWeek;


            //Console.WriteLine("===========================================");
            //Console.WriteLine($"Age                 : {age}");

            //Console.WriteLine(age*12);

            //Console.WriteLine($"Is {bdate.Year} leap year ?  :  {DateTime.IsLeapYear(bdate.Year)}");



            //Console.WriteLine($"day of the year of DOB        :{doy}");
            //Console.WriteLine($"day of the week of DOB        :{dow}");

            //string s = "hi";
            //Console.WriteLine(s);
            //s = "hello";
            //Console.WriteLine(s);
            //Console.WriteLine(s);

            StringBuilder sb = new StringBuilder();
            sb.AppendLine("hi");
            sb.AppendLine("hello");

            Console.WriteLine(sb);

        }
    }
}
