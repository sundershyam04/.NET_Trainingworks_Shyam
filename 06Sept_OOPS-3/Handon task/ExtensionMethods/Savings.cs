using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExtensionMethods
{

    interface Ibank
    {
        void Printbalance();
        void Calculateinterest();

    }

    public class Savings : Ibank
    {
        public Savings()
        {
            Console.WriteLine("Savings bank acc created successfully.....");
        }



        public static int bal = 0;

        public int Balance
        {
            get { return bal; }
            set { bal = value; }
        }

        public void Calculateinterest()
        {
            double interest = bal * (0.04);
            Console.WriteLine($"Interest: {interest}");

        }

        public void Printbalance()
        {
            Console.WriteLine($"Balance : {bal}");

        }

        //public void withdraw(int amt)
        //{
        //    if (bal >= amt)
        //    {
        //        bal = bal - amt;
        //        Console.ForegroundColor = ConsoleColor.Green;
        //        Console.WriteLine($"Rs.{amt} Withdrawn successfully");
        //        Console.ForegroundColor = ConsoleColor.White;
        //    }
        //    else
        //    {
        //        Console.ForegroundColor = ConsoleColor.Red;
        //        Console.WriteLine("!!!! Insufficient balance......");
        //        Console.ForegroundColor = ConsoleColor.White;
        //    }

        //}
    }
}
