using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace arrayofstruct
{
    internal class Program
    {
        struct Student
        {
            public int _empno;
            public string _name;
             public int _salary;
             public int _deptno;
            public void AcceptData(int empno,string name,int salary, int deptno)
            {
                _empno = empno;
                _name = name;
                _salary=salary;
                _deptno = deptno;
            }
            public void Display()
            {               
                Console.WriteLine($"Rollno:   {_empno}");
                Console.WriteLine($"Name :    {_name}");
                Console.WriteLine($"Salary :  {_salary}");
                Console.WriteLine($"Deptno :  {_deptno}");
            }

        }

        static void Main(string[] args)
        {
            Student[] students = new Student[4];
            for (int i = 0; i < 4; i++)
            {
                Console.WriteLine($"=======students[{i}]========");
                Console.WriteLine("Enter empno");
                int empno = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("enter name");
                string name = Console.ReadLine();

                Console.WriteLine("enter salary");
                int salary = int.Parse(Console.ReadLine());

                Console.WriteLine("enter Deptno");
                int deptno = int.Parse(Console.ReadLine());

                students[i].AcceptData(empno, name,salary,deptno);
            }
            Console.WriteLine("====Display function=====");

            for (int i = 0; i < 4; i++)
            {
                Console.WriteLine($"====students[{i}]=====");
                students[i].Display();
            }
            Console.Read();
        }
    }
}
