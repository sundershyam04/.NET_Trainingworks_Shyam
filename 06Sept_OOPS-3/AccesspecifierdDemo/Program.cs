using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AccesspecifierDemo
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Employee emp = new Employee();
            //emp.Empid = 101;
            //emp.Password = "abc@123";
            ATM  n= new ATM();
            n.ShowMenu();
            //Employee emp = new Employee();
            //emp.Empid = 101;
            //emp.Password = "abc@123";
            //ATMMachine machine = new ATMMachine();
            //machine.ShowMenu();

            //Person p = new Person();
            //p[0] = "CH";
            //Console.WriteLine(p[0]);
            //Console.WriteLine(p[1]);
            //Console.WriteLine(p[2]);
            //Console.WriteLine(p[3]);
            //Console.WriteLine(p[4]);
            //ExtensionMethodsDemo.newmethod();
            //Person p1 = new Person();
            //p1.method1();

            string s = "hello";

            //s.LengthOfString();

            //int i = 10;
            //int areaOFSq = i.calculateArea();
            //Console.WriteLine(areaOFSq);

            //int j = 20;
            //float area = j.calculateArea(15);
            //Console.WriteLine(area);


            List<int> list = new List<int>();
            list.Add(100);
            list.Add(101);
            list.Add(120);
            list.Add(31);
            list.Add(33);
            list.Add(43);
            list.Add(19);
            list.Add(5);

            double avgOfNos = list.Average();
            Console.WriteLine("Average=" + avgOfNos);
            int a = list.ElementAt(0);
            Console.WriteLine("Elemnet at=" + a);

            int[] arr = new int[] { 3, 13, 4, 322, 22 };


            Console.Read();

            Console.Read();


        }
    }
}
