using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace reusablecode
{
   public class Upper
    {
        public static void to_up()
        {
            Console.WriteLine("Enter a string: ");
            string str=Console.ReadLine();

            string u=str.ToUpper();
            Console.WriteLine($"Uppercase  : {u}");

        }
    }
}
