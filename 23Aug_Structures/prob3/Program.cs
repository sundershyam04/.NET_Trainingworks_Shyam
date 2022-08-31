using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace prob3
{
    internal class Program
    {
        struct Employee
        {
            public int empno;
            public string ename;
            public int salary;
            public int deptno;
          // 4 properties for 4 fields

            public int EmpNo
            {

                get { return empno; }   
                set { empno = value; }
            }
            public string Ename
            {

                get { return ename; }
                set { ename = value; }
            }
            public int Sal
            {

                get { return salary; }
                set { salary = value; }
            }
            public int Deptno
            {

                get { return deptno; }
                set { deptno = value; }
            }

        }
        static void Main(string[] args)
        {

            Employee emp = new Employee();

            Console.WriteLine("Enter emp name");
            emp.Ename=Console.ReadLine();

            Console.WriteLine("Enter emp no");
            emp.EmpNo=int.Parse(Console.ReadLine());

            Console.WriteLine("Enter dept no");
            emp.Deptno=int.Parse(Console.ReadLine());

            Console.WriteLine("Enter salary:");
            emp.Sal= int.Parse(Console.ReadLine());

            Console.WriteLine("Emp details using properties");
            Console.WriteLine(emp.Ename);
            Console.WriteLine(emp.EmpNo);
            Console.WriteLine(emp.Deptno);
            Console.WriteLine(emp.Sal);
            
            


                
        }
    }
}
