using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BasicDemo
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Multiplication of two numbers
            int a = 50;
            int b = 5;
            int c = a * b;
            Console.WriteLine("a*b : {0}",c);
            Console.WriteLine("--------------------------");

            // string inputs
            Console.Write("Enter username : ");
            string username=Console.ReadLine();

            Console.Write("Enter password : ");
            string password=Console.ReadLine();

            Console.WriteLine("Username : {0}\nPassword : {1}",username,password);
            Console.WriteLine("--------------------------");

            //ifelse 

            Console.Write("Enter age : ");
            int age = int.Parse(Console.ReadLine());
            Console.WriteLine("-----");

            if (age >= 18)
                Console.WriteLine("Major");
            else
                Console.WriteLine("Minor");

            Console.WriteLine("-----");
        }
    }
}
