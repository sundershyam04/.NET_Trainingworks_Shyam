using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Classdefn
{
    public class Employee
    {
        //Name
        private string _name;

        public string Name
        {
            get { return _name; }
            set { _name = value; }
        }

        //salary

        private int _sal;
		
		public int Salary				 // used for validation - fullyimplemenntedprop
		{
			get { return _sal ; }
			set { _sal = value; }
		}

		//public int ID { get; set; }     // auto implem prop (no validation purpose)

		public void display(int k)
        {
            Console.WriteLine($"===Emp[{k}]");
            Console.WriteLine($"Name   : {_name}");
            Console.WriteLine($"Salary : {_sal}");
        }


	}
}
