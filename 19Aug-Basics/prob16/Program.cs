using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace prob16
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int pts = 100;
            string action;
            for (int i = 0; i < 4; i++)
            {
                action = Console.ReadLine();
                if (action == "HIT") 
                    pts += 10;
                else if (action == "MISS")
                    pts -= 20;
            }

            Console.WriteLine($"Points  : {pts}");


        }
    }
}
