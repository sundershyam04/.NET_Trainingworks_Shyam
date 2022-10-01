using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;
using System.Xml;
using BLL;
using HELPER;
namespace IMSapp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("-----INSTITUTE MANAGEMENT MANAGEMENT (IMS)-----");
            HelperClass helper= new HelperClass();

            Console.WriteLine("Menu\n1 - Insert Course\n2 - Insert Student\n3 - Insert Exam");
            try
            {

                int choice = Convert.ToInt32(Console.ReadLine());

                switch (choice)
                {

                    case 1:
                        course c1 = new course();
                        Console.WriteLine("Enter course id  :");
                        c1.courseid = Convert.ToInt32(Console.ReadLine());
                        Console.WriteLine("Enter course name:");
                        c1.coursename = Convert.ToString(Console.ReadLine());
                        Console.WriteLine("Enter dept id    :");
                        c1.deptid = Convert.ToString(Console.ReadLine());
                        Console.WriteLine("Enter duration   :");
                        c1.duration = Convert.ToInt32(Console.ReadLine());
                        if (helper.Insert(c1))
                        {
                            Console.WriteLine("Course added successfully");
                        }
                        else
                        {
                            Console.WriteLine("Course not added");
                        }
                        break;

                    case 2:
                        Student s1 = new Student();
                        Console.WriteLine("Enter student id  :");
                        s1.StudentId = Convert.ToInt32(Console.ReadLine());
                        Console.WriteLine("Enter student name:");
                        s1.StudName= Convert.ToString(Console.ReadLine());
                        Console.WriteLine("Enter course id    :");
                        s1.CourseId = Convert.ToInt32(Console.ReadLine());
                      
                        
                        if (helper.Insertstud(s1))
                        {
                            Console.WriteLine("Student added successfully");
                        }
                        else
                        {
                            Console.WriteLine("Student not added");
                        }
                        break;


                }
            }
             catch(Exception e)
            {
                Console.WriteLine(e.Message);

            }

            Console.Read();
        }
    }
}
