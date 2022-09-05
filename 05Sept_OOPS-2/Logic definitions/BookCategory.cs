using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Logic_definitions
{
    public class BookCategory
    {
		//1
		private int _catid;

		public int CatId
		{
			get { return _catid; }
			set { _catid = value; }
		}
		//2
		private string _catname;

		public string CatName
		{
			get { return _catname; }
			set { _catname = value; }
		}
		//3
		private string _desc;

		public string Description
		{
			get { return _desc; }
			set { _desc = value; }
		}

		public BookCategory()
		{
			Console.WriteLine("BookCategory : Default constructor");
		}
		public BookCategory(int id,string name,string des)
		{
			Console.WriteLine("BookCategory : Parametrized constructor");

			CatId = id;
			CatName = name;	
			Description=des;

		}
		private List<Book> _cblist;
		public List<Book> Cblist { 
		      get{ return _cblist; }

			 set { _cblist = value;}
		}

	}
}
