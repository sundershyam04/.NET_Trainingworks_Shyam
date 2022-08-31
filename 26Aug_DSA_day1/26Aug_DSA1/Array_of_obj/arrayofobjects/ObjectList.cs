using Classdefn;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace arrayofobjects
{
    internal class ObjectList


    {

        static void Main(string[] args)
        {
            List<Employee1> emp= new List<Employee1>();

            emp.Add(new Employee1
            {

                City = "Pune",
                EmpID = 1,
                EmpName = "sathish", 
                DeptNo=8,

            });

            // or first obj creation separate and the add at once

            foreach (var item in emp)
            {
                Console.WriteLine(item.EmpID);
                Console.WriteLine(item.EmpName);
                Console.WriteLine(item.DeptNo);
                Console.WriteLine(item.City);
                item.CalculateSalary(1000);
                Console.WriteLine(item.GrossSalary);
            }
          

        }
    }
}
