using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace prob6
{
    internal class Program
    {
        public enum DeptName {
        
        Purchase=1,
        Sales,
        Training,
        Accounts
      
        }


        static void Main(string[] args)
        {


            //    for (int i = 0; i < 4; i++) 
            //    {
            //        Console.WriteLine("Enter a string: ");
            //        string s = Console.ReadLine();
            //        DeptName d1 = (DeptName)Enum.Parse(typeof(DeptName), s, true);
            //        Console.WriteLine((int)d1);
            //}
            for (int i = 0; i < 4; i++)
            {
                Console.WriteLine("Enter a string: ");
                string s = Console.ReadLine();
                int  d1 = (int)Enum.Parse(typeof(DeptName), s, true);
                Console.WriteLine($"Deptnumber :{d1}") ;
                Console.WriteLine("================================================");
            }

            Console.ReadLine();
        }



        }
}
