using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StructDemo
{
    internal class Program
    {
        struct Car {
            public string name;
            public string  model;
            public Car(string name, string model)
            {
                this.name = name;
                this.model = model;
                this._r = 0;
            }
            public int _r;
            //Property 
            public int Ratings
            {
                get { return _r; }

                set {
                    _r = value;
                }
            }




            public void print()
            {
                Console.WriteLine(name);
                Console.WriteLine(model);
            }
        }


        static void Main(string[] args)
        {
            Car c1 = new Car("Kia","2020");
            Console.WriteLine("c1 struct contents");
            c1.print();

            Console.WriteLine( "Enter ratings: ");
            c1.Ratings = int.Parse(Console.ReadLine());

            Console.WriteLine($"Using property  :{c1.Ratings}");
            Console.WriteLine($"Using field name:{c1._r}");
            Console.WriteLine("=================");


            Console.ReadLine();
        }
    }
}
