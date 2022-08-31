using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace prob4
{
    internal class Program
    {
        struct Employee
        {
            public int empno;
            public string ename;
            public int salary;
            public int deptno;
            public void AcceptData(int empno,string ename,int salary,int deptno)
            {
                this.empno= empno;
                this.ename = ename;
                this.salary= salary;
                this.deptno= deptno;
            }
            public void Display()
            {
                Console.WriteLine($"Employee no: {empno}" +
                        $"\nName:  {ename}" +
                        $"\nSalary: {salary}" +
                        $"\nDeptno: {deptno}"
                        );    

            }

        }
        static void Main(string[] args)
        {

            Employee emp = new Employee();

            emp.AcceptData(205, "gopal", 25600, 8);
            emp.Display();
        }
    }
}
