using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Reflection;

namespace Handson__A_
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string path = @"C:\Users\SHYAM SUNDER\Desktop\HandsOn .NET\handon_assignments©\12Sept_Reflection\Calculator\bin\Debug\Calculator.dll";

            Assembly asc = Assembly.LoadFrom(path);

            Type[] types = asc.GetTypes();

            foreach (var item in types)
            {
                Console.WriteLine("Full Name : " + item.FullName);
                Console.WriteLine("Is Public : " + item.IsPublic);


                Console.WriteLine("--------------CALCULATOR----------------");

                Type t = asc.GetType(item.FullName); // obj 

                Console.WriteLine("==>Object created....");

                object obj = Activator.CreateInstance(t);

                Console.WriteLine("Enter the double number:");
                double dd=Double.Parse(Console.ReadLine());

                item.InvokeMember("Accept", BindingFlags.Public | BindingFlags.Instance | BindingFlags.InvokeMethod, null, obj, new object[1] { dd });


                Console.WriteLine("==>Parameter passed to Calculator...");


                Console.ForegroundColor = ConsoleColor.DarkYellow;
                Console.WriteLine("----------------------------");

                item.InvokeMember("Cube", BindingFlags.Public | BindingFlags.Instance | BindingFlags.InvokeMethod, null, obj, null);

                item.InvokeMember("Sqrt", BindingFlags.Public | BindingFlags.Instance | BindingFlags.InvokeMethod, null, obj, null);

                Console.WriteLine("----------------------------");
            }
        }
    }
}
