using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LOGIC

{
    public class Product
    {
        static public int Prodcount = 0;
        private int _prodid;

		public int ProdID
		{
			get { return _prodid; }
			set { _prodid = value; }
		}

		private string _name;

		public string Name
		{
			get { return _name; }
			set { _name = value; }
		}

		private int _qtysold;

		public int Qtysold
		{
			get { return _qtysold; }
			set { _qtysold = value; }
		}

		private int _unitprice;

		public int Unitprice
		{
			get { return _unitprice; }
			set { _unitprice = value; }
		}

		private string  _unitmeas;

		public string  Unitmeasurement
		{
			get { return _unitmeas; }
			set { _unitmeas = value; }
		}

		private int _inhandqty;

		public int InhandQty
		{
			get { return _inhandqty; }
			set { _inhandqty = value; }
		}
		private string _reordlevel;

		public string Reorderlvl
		{
			get { return _reordlevel; }
			set { _reordlevel = value; }
		}

		public void Addproduct()
		{

            Console.WriteLine("Enter product ID");
            ProdID = int.Parse(Console.ReadLine());

            Console.WriteLine("Enter productname");
            Name = Console.ReadLine();

            Console.WriteLine("Enter quantity sold");
            Qtysold = int.Parse(Console.ReadLine());

            Console.WriteLine("Enter price of a unit");
            Unitprice = int.Parse(Console.ReadLine());

            Console.WriteLine("Enter measurement unit");
            Unitmeasurement = Console.ReadLine();

            Console.WriteLine("Enter Inhand quantity");
            InhandQty = int.Parse(Console.ReadLine());

            Console.WriteLine("Enter reorderlevel(high / medium / low");
            Reorderlvl = Console.ReadLine();

            Console.WriteLine("********************************");

            Product.Prodcount += 1;

        }








	}
}
