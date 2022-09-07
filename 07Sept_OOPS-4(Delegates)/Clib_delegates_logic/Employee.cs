using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace logic
{
	public delegate void YOS(Employee e);
    public class Employee
    {
		private int _joinyear;

		public int JoiningYear
		{
			get { return _joinyear; }
			set { _joinyear = value; }
		}

		public void yearofservice(Employee e)
		{
			int y = DateTime.Now.Year;

			int yos = (y - e.JoiningYear);
			Console.WriteLine($"Year of service : {yos}");

		}
	}
}
