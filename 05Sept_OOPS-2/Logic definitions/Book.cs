using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Logic_definitions
{
    public class Book : BookCategory
    {
        //1
        private int _bookid;

        

        public int BookId
        {
            get { return _bookid; }
            set { _bookid = value; }
        }
        //2
        private string _name;

        public string Name
        {
            get { return _name; }
            set { _name = value; }
        }

        //3
        private string _author;

        public string Author
        {
            get { return _author; }
            set { _author = value; }
        }
        //4
        private float _price;

        public float Price
        {
            get { return _price; }
            set { _price = value; }
        }




        public Book()
        {
            Console.WriteLine("Default constructor...");
        }
        public Book(int ID,string name)
        {
            Console.WriteLine("Parametrized constructor...");
        }

        // < POLYMORPHISM > functions 
        public void Insertbook(int bookid,string name,float price,Book b)
        {

            this._bookid = bookid;
            this._name = name;
            this._price = price;
            

        }

        public void Insertbook(int bookid, string name, float price,string author,Book b)
        {
            this.BookId=bookid;
            this.Name = name;
            this.Price = price;
            this.Author = author;
           
        }

        public void Insertbook(int bookid, string name,Book b)
        {
            this.BookId = bookid;
            this.Name = name;

            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine("=>Added successfully....");
            Console.ForegroundColor = ConsoleColor.White;
        }
    }

}
