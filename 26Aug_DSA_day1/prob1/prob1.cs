using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace prob1
{
    struct Student
    {
        public int RollNo;
        public string Name;
        public int Age;
        public int grade;

        public void display(int i)
        {
            Console.WriteLine($"===st[{i}]===");
            Console.WriteLine($"Roll Number : {RollNo}");
            Console.WriteLine($"Name        : {Name}");
            Console.WriteLine($"Age         : {Age}");
            Console.WriteLine($"Grade       : {grade}");
        }
    }
    internal class prob1
    {
       
        static void Main(string[] args)
        {
            Student[] st = new Student[2];

            for(int i = 0; i < st.Length; i++)
            {   
                Console.WriteLine($"===Student[{i}]====");
                st[i]= new Student();

                Console.WriteLine("Enter Roll Number :");
                st[i].RollNo = int.Parse(Console.ReadLine());

                Console.WriteLine("Enter Student Name:");
                st[i].Name = Console.ReadLine();

                Console.WriteLine("Enter Age :");
                st[i].Age = int.Parse(Console.ReadLine());

                Console.WriteLine("Enter Grade :");
                st[i].grade = int.Parse(Console.ReadLine());

            }

            Console.WriteLine("Calling display function.......");
            for(int i = 0; i < st.Length; i++)
            {
                st[i].display(i);
            }
            Console.Read();

        }
    }
}
