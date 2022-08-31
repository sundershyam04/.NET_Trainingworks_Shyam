using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace reusablecode
{
    public class Day
    {
        public static void fn()
        {

            DateTime today=DateTime.Now;
            Console.WriteLine("todays datetime:");
            Console.WriteLine(today);

            Console.WriteLine("todays date:");
            Console.WriteLine(today.Day);

            Console.WriteLine("todays month:");
            Console.WriteLine(today.Month);

            Console.WriteLine("todays year:");
            Console.WriteLine(today.Year);

            Console.WriteLine("Hour:");
            Console.WriteLine(today.Hour);

            Console.WriteLine("Min:");
            Console.WriteLine(today.Minute);

            Console.WriteLine("Second:");
            Console.WriteLine(today.Second);

            Console.WriteLine("millisecond :");
            Console.WriteLine(today.Millisecond);

            Console.WriteLine(today.DayOfYear);
            Console.WriteLine(today.DayOfWeek);
          
            Console.WriteLine(today.TimeOfDay);
            



        }
    }
}
