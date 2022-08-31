using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Globalization;

namespace FileHandling
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter file name:");
            string name = Console.ReadLine();

            string path = @"C:\Users\SHYAM SUNDER\Desktop\HandsOn .NET\handon_assignments\25Aug\FileHandling\";

            //File.Create(path+name);

            Console.WriteLine("File created successfully.................");

            /// write operation
            
            Console.WriteLine("Enter file contents:");
            string cont=Console.ReadLine();

            string[] s = { cont };
            //File.WriteAllLines(name, s);
            //File.WriteAllText(name, cont);

            File.AppendAllText("appenddemo.txt", cont);   
        }
    }
}
