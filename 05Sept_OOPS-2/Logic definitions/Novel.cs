using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Logic_definitions
{
    public class Novel:Book
    {
        private int _pages;

        public int Noofpages
        {
            get { return _pages; }
            set { _pages = value; }
        }

        new public void Insertbook(int bookid, string name, float price,int noofpages)
        {
            this.BookId = bookid;
            this.Name = name;
            this.Price = price;
            this.Noofpages=noofpages;

        }

    }
}
