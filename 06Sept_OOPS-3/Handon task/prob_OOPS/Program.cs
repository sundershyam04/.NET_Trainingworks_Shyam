using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ExtensionMethods;


namespace prob_OOPS
{
    


    internal class Program
    {
        static void Main(string[] args)
        {

            Manager m = new Manager();

            Employee e = new Employee();

            Clerk c = new Clerk();

            m.Work();

            e.Work();

            c.Work();

            Console.WriteLine("----------------------------------");

            Console.WriteLine("------XYZ bank-----");

            //SAVING BANK ACC

            Savings savings = new Savings();
            DateTime wd, dd;

            savings.Printbalance();

            dd=savings.deposit();

            savings.Printbalance();

            

            wd=savings.withdraw();

            savings.Printbalance();

            savings.Calculateinterest();

            Console.WriteLine($"No .of .days deposited amount in the bank: " +
               $"{(wd - dd).Days}");


            Console.WriteLine("**********************************8");
            //CURRENTBANK ACC

            Current current = new Current();

            current.Printbalance();

            dd=current.deposit();
           
            current.Printbalance();

            wd=current.withdraw();  //withdraw 6000rs from bal

            current.Printbalance();

            current.Calculateinterest();

            Console.WriteLine($"No .of .days deposited amount in the bank: " +
              $"{(wd - dd).Days}");



        }
    }
    }

