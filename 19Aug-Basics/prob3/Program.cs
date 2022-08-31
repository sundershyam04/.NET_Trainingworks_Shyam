using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace prob3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            char s1 = 'd';
            char s2 =  'a';
            bool res=false;
            if (s1 == s2) res = true;
            Console.WriteLine($"s1 : {s1}  s2 :{s2} \n " +
                $" Is s1 equals to s2: {s1.Equals(s2)} (or) {res}");
        }
    }
}
