using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;



namespace ExtensionMethods
{
    public static class Banking
    {
        //for savings 
        public static DateTime withdraw(this Savings s)
        {
            
            Console.WriteLine("Enter amount to be withdrawn");
            int amt=int.Parse(Console.ReadLine());
            if (s.Balance >= amt)
            {
                s.Balance = s.Balance - amt;
                Console.ForegroundColor = ConsoleColor.Green;
                Console.WriteLine($"Rs.{amt} Withdrawn successfully");

                DateTime wd = new DateTime(22, 9, 18);
                //Console.WriteLine(wd);
                Console.ForegroundColor = ConsoleColor.White;

                return wd;
            }
            else
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("!!!! Insufficient balance......");
                Console.ForegroundColor = ConsoleColor.White;
                return default;
            }

        }

        public static DateTime deposit(this Savings s)
        {
            Console.WriteLine("Enter amount to be deposited");
            int amt = int.Parse(Console.ReadLine());

            if (amt>0)
            {
                 s.Balance=s.Balance + amt;
                Console.ForegroundColor = ConsoleColor.Green;
                Console.WriteLine($"Rs.{amt} Deposited successfully");
                Console.ForegroundColor = ConsoleColor.White;
                Console.WriteLine("----------------------------------");
                DateTime dd = new DateTime(22, 9, 06);
                return dd;
            }
            else
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("!!!!0 can't be a amount");
                Console.ForegroundColor = ConsoleColor.White;
                return default;
            }
            

        }

        //for current-------------------------------------------

        public static DateTime withdraw(this Current c)
        {

            Console.WriteLine("Enter amount to be withdrawn");
            int amt = int.Parse(Console.ReadLine());
            if (c.Balance >= amt)
            {
                c.Balance = c.Balance - amt;
                Console.ForegroundColor = ConsoleColor.Green;
                Console.WriteLine($"Rs.{amt} Withdrawn successfully");
                Console.ForegroundColor = ConsoleColor.White;
                DateTime wd = new DateTime(22, 9, 19);
                return wd;

            }
            else
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("!!!! Insufficient balance......");
                Console.ForegroundColor = ConsoleColor.White;
                return default;
            }

        }

        public static DateTime deposit(this Current c)
        {
            Console.WriteLine("Enter amount to be deposited");
            int amt = int.Parse(Console.ReadLine());

            if (amt > 0)
            {
                c.Balance = c.Balance + amt;
                Console.ForegroundColor = ConsoleColor.Green;
                Console.WriteLine($"Rs.{amt} Deposited successfully");
                Console.ForegroundColor = ConsoleColor.White;
                DateTime dd = new DateTime(22, 9, 06);
                return dd;
            }
            else
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("!!!!0 can't be a amount");
                Console.ForegroundColor = ConsoleColor.White;
                return default;
            }
            Console.WriteLine("----------------------------------");

        }
    }
}
