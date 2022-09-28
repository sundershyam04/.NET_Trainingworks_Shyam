using DAC_Library;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace BAL_Library
{
    public class Libraryoperations
    {


        public List<BookBAL> GetBooks()
        {
            LibEntities context= new LibEntities();

            List<LibBook> blist = context.LibBooks.ToList();

            List<BookBAL> bookballist = new List<BookBAL>();

            foreach (var item in blist)
            {
                bookballist.Add(new BookBAL { Book_No = (int)item.Book_No, Book_Name = item.Book_Name, Author = item.Author, Cost = (int)item.Cost, Category = item.Category });
            }

            return bookballist;
        }


        //insert books

        public void InsertBooks(BookBAL b)
        {
            LibEntities context = new LibEntities();

            //New book of default <Libbook> type as in database

            LibBook finalbk = new LibBook();
            finalbk.Book_No = b.Book_No;
            finalbk.Book_Name = b.Book_Name;
            finalbk.Author = b.Author;
            finalbk.Cost = b.Cost;
            finalbk.Category = b.Category;

            context.LibBooks.Add(finalbk);

            context.SaveChanges();

        }
        //Updatebook

        public void UpdateBook(int book_no,BookBAL b)
        {
            LibEntities context = new LibEntities();

            List<LibBook> blist = context.LibBooks.ToList();

           LibBook found = blist.Find(x => x.Book_No == book_no);

            found.Book_Name = b.Book_Name;
            found.Author = b.Author;
            found.Cost = b.Cost;
            found.Category= b.Category;

            context.SaveChanges();

        }

        public void DeleteBook(string name)
        {
            LibEntities context = new LibEntities();

            context.sp_deleteBook(name);

            context.SaveChanges();

        }




    }
}
