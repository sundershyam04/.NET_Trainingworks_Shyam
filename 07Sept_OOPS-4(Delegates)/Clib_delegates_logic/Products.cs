using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace logic
{
	public delegate void Printdata(Products prod);
   public class Products
    {
		private int _id;

		public int Id
		{
			get { return _id; }
			set { _id = value; }
		}

		private string _name;

		public string Name
		{
			get { return _name; }
			set { _name = value; }
		}
		public void getdetails()
		{
            Console.WriteLine("Enter prod ID");
            this.Id = int.Parse(Console.ReadLine());
            Console.WriteLine("Enter prod name");
            this.Name = Console.ReadLine();

        }
	    public void printdetails(Products p)
		{

			Console.ForegroundColor = ConsoleColor.DarkCyan;

			Console.WriteLine($"Product Id  : {Id}");
			Console.WriteLine($"Product Name: {Name}");

            Console.ForegroundColor = ConsoleColor.White;
        }

	}
}
