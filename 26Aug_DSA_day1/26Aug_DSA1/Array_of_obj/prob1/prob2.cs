using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace prob1
{
    class Students
    {
        private int _rollno;

        public int RollNo
        {
            get { return _rollno; }

            set { _rollno = value; }
        }

        private string _name;

        public string Name
        {
            get { return _name; }

            set { _name = value; }
        }

        private int _age;

        public int Age
        {
            get { return _age; }

            set { _age = value; }
        }
        private int _grade;

        public int Grade
        {
            get { return _grade; }

            set { _grade = value; }
        }

        public void display(int i)
        {
            Console.WriteLine($"===student[{i}]===");
            Console.WriteLine($"Roll Number : {RollNo}");
            Console.WriteLine($"Name        : {Name}");
            Console.WriteLine($"Age         : {Age}");
            Console.WriteLine($"Grade       : {Grade}");
        }



    }


    internal class prob2
    {

        static void Main(string[] args)
        {

            Students[] student = new Students[2];  // student array [    ]  of classtype

            for (int i = 0; i < student.Length; i++)
            {

                Console.WriteLine($"===student[{i}]===");
                student[i] = new Students();      // obj creation for each element

                Console.WriteLine("Enter Roll Number :");
                student[i].RollNo = int.Parse(Console.ReadLine());

                Console.WriteLine("Enter Student Name:");
                student[i].Name = Console.ReadLine();

                Console.WriteLine("Enter Age :");
                student[i].Age = int.Parse(Console.ReadLine());

                Console.WriteLine("Enter Grade :");
                student[i].Grade = int.Parse(Console.ReadLine());

            }

            Console.WriteLine("Calling display function.......");
            for (int i = 0; i < student.Length; i++)
            {
                student[i].display(i);
            }

            Console.Read();

        }
    }
}
