using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Classdefn;

namespace arrayofobjects
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Employee[] emp = new Employee[2];   //creates only arry of type Employee [     ] 

            for(int i=0;i<emp.Length;i++)
            {
                emp[i] = new Employee();        // important @objcreation  
                Console.WriteLine($"===emp[{i}]===");
                Console.WriteLine("Enter empname:");
                emp[i].Name = Console.ReadLine();
                Console.WriteLine("Enter SALARY:");
                emp[i].Salary = int.Parse  (Console.ReadLine());


            }

            for(int j = 0; j < emp.Length; j++)
            {
                emp[j].display(j);
            }


        }
    }
}
