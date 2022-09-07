using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;
using logic;

namespace Delegates

{
    public delegate string Concatdelegate(string s1,string s2);

    public delegate string UppercaseDelegate(string s1);
    //public delegate string Concatdelegate(Concat c);
    public class Concat 
    {
        public string s1, s2;
        public string concat(Concat c)
        {

            string final = string.Concat(c.s1, c.s2);                         //c.s1 + c.s2;
            return final;

        }
    
    }



    internal class Program
    {
        static void Main(string[] args)
        {
            //1

            Console.WriteLine("-----PROB 1-----");
            Console.WriteLine("Enter a string :");
            string s = Console.ReadLine();



            Strings obj = new Strings();

            // TARGET FOR DELIGATE

            lendeligate len = new lendeligate(obj.getlenth);

            int n = len(s);

            Console.WriteLine($"Length of string s: {n}");

            Console.WriteLine("-----------------");

            Console.WriteLine("-----PROB 2-------");

            //2 - creating del obj for greetuser()

            Greet g = obj.greetuser;

            Console.WriteLine("Enter name");
            string name = Console.ReadLine();
            g.Invoke(name);  // g( name );
            Console.WriteLine("-------------------");


            //3 - 

            Console.WriteLine("--PROB 3 -ARITHMETIC OPR");

            Console.WriteLine("Enter 2 integer nos");

            int x = Convert.ToInt32(Console.ReadLine());
            int y = Convert.ToInt32(Console.ReadLine());

            Arithmetic a = new Arithmetic();

            Ari add = a.Addition;
            Ari sub = a.Subtraction;
            Ari mul = a.Multiplication;
            Ari div = a.Division;
            Console.WriteLine("---Unicast : Individual call----------");

            //Console.WriteLine($"Addition : { add(x,y) }");

            //Console.WriteLine($"Subtraction : { sub(x, y) }");

            //Console.WriteLine($"Multiplication : { mul(x, y) }");

            //Console.WriteLine($"Division : { div(x, y) }");

            add(x, y);
            sub(x, y);
            mul(x, y);
            div(x, y);


            Console.ForegroundColor = ConsoleColor.Green;

            Console.WriteLine("---Multicast----------");
            Ari[] total = { add, sub, mul, div };

            Ari final = (Ari)MulticastDelegate.Combine(total);

            final(x, y);

            Console.ForegroundColor = ConsoleColor.White;

            Console.WriteLine("-----------PROB 4--------------");


            //Delegate -public delegate void Printdata(Products prod);

            Products p1 = new Products();
            p1.getdetails();

            Printdata print = p1.printdetails;      // delegate pt to printdetails fn

            //print(p1);

            Console.WriteLine("---------Printing details--------");
            print.Invoke(p1);

            Console.WriteLine("-----------PROB 5- Yearofservice------------");

            Employee emp = new Employee();

            Console.WriteLine("Enter Joining Year: ");
            emp.JoiningYear = int.Parse(Console.ReadLine());

            YOS yos = emp.yearofservice;
            yos(emp);

            Console.WriteLine("-------------PROB 6 - Concat strings--------");

            Concat c = new Concat();

            Console.WriteLine("Enter string 1");
            c.s1 = Console.ReadLine();
            Console.WriteLine("Enter string 2");
            c.s2 = Console.ReadLine();

            //using  lambda exp

            Concatdelegate cd = delegate (string l, string p )
            {
                return string.Concat(l, p);
            };
                
                
              // for general method : cd = c.concat;

            Console.WriteLine($"Concatenation of strings: { cd(c.s1,c.s2) }");

            Console.WriteLine("-------------PROB 7 - first char uppercase--------");
            Console.WriteLine("Enter a string: ");
            string u = Console.ReadLine();

            UppercaseDelegate uc = delegate (string st)
            {

                return (char.ToUpper(st[0]) + st.Substring(1)); 
            };

            Console.WriteLine(uc(u));

        }
        
    }     
       
}


    

