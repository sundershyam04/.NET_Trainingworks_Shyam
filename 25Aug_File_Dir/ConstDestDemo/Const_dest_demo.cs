using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConstDestDemo
{

    class Car :IDisposable {
        public string Name;
        public string model;
        public Car( string s , string n)
        {
            Name = s;
            model = n;
            Console.WriteLine("parametrized constructor");
        }
        public Car()
        {
            Console.WriteLine("dEfault constructor called");
        }
        public void acceptdata(string a,string b)
        {
            Name = a; 
            model = b;
        }
        public void display()
        {
            Console.WriteLine("=====car object=====");
            Console.WriteLine($"Name :{Name}\nModel :{model}");
            Console.WriteLine("=====================");
        }


        public void Dispose()
        {
            //throw new NotImplementedException();
            Console.WriteLine("Disposed called");
        }

        ~Car()
        {

        }
    
    }



    internal class Program
    {
        static void Main(string[] args)
        {
            Car car1 = new Car();

            Car car2 = new Car("honda", "2009");

            car1.acceptdata("kIA", "2020");
            car1.display();
            car2.display();

            car2.Dispose();
            car1.Dispose();
        }
    }
}
