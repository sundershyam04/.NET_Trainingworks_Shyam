using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace prob9
{
    internal class Program
    {
        struct Student
        {
            public int _empno;
            public string _name;
            public int _salary;
            public int _deptno;
            public void AcceptData(int empno, string name, int salary, int deptno)
            {
                //validation- empno
               
                if (empno != 0) { _empno = empno; }
                else
                                {
                                    Console.WriteLine("empno should not be zero");
                                }
                
                //validation - deptno

                if (deptno != 0) { _deptno = deptno; }
                else
                            {   
                                Console.WriteLine("deptno should not be zero");
                            }
                if (string.IsNullOrEmpty(name)) 
                            { Console.WriteLine("Name should not be empty"); }
                else        { _name = name; }
                    
                _salary = salary;

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
            Student[] students = new Student[2];
            for (int i = 0; i < 2; i++)
            {
                try { 
                Console.WriteLine($"=======students[{i}]========");
               
                Console.WriteLine("Enter empno");
                int empno = Convert.ToInt32(Console.ReadLine());

                Console.WriteLine("enter name");
                string name = (string)Console.ReadLine();

                Console.WriteLine("enter salary");
                int salary = int.Parse(Console.ReadLine());

                Console.WriteLine("enter Deptno");
                int deptno = int.Parse(Console.ReadLine());

                students[i].AcceptData(empno, name, salary, deptno);   
                    }
                catch(Exception e) 
                {   Console.WriteLine("=============================");
                    Console.WriteLine($"MESSAGE : {e.Message}");
                    Console.WriteLine($"Info :    {e.StackTrace}");
                    Console.WriteLine($"Source:   {e.Source}");
                    Console.WriteLine("=============================");
                }
            }
            Console.WriteLine("====Display function=====");

            for (int i = 0; i < 2; i++)
            {
                Console.WriteLine($"====students[{i}]=====");
                students[i].Display();
            }
            Console.Read();
        }
    }
}

