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

            Console.WriteLine("Enter username password :");
            string username = Console.ReadLine();
            string password = Console.ReadLine();

            string u = "sunder";
            string p = "spoi908";

            if (username == u && password == p)
            {

                Console.WriteLine("Successfully logged in");
                Console.WriteLine("Welcome to my App");

            }
            else
            {
                Console.WriteLine("!!!! Incorrect login credentials,Retry!!!!");
            }
        }
    }
}
