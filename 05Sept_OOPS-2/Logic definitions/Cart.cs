using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Logic_definitions
{
    public class Cart
    {

		static int count=0;

		List<Book> books=new List<Book>();
		//custid
		private int _custid;

		public int CustId
		{
			get { return _custid; }
			set { _custid = value; }
		}
		//Bookid
		

		

		//Add books to cart
		public void AddToCart(Book b)
		{
			books.Add(b);

            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine("=>Added successfully to Cart....");
            Console.ForegroundColor = ConsoleColor.White;

			count++;	


        }

		public	void DisplayCart()
		{
            Console.ForegroundColor = ConsoleColor.DarkYellow;
            Console.WriteLine("............CART..............");
            Console.ForegroundColor = ConsoleColor.White;

            Console.WriteLine($"Customer ID: {CustId}");
            foreach (var item in books)
			{

                Console.WriteLine($"BookID : {item.BookId}");

                Console.WriteLine($"Book name :{item.Name}");

                Console.WriteLine($"Author: {item.Price}");
				Console.WriteLine("...............................");

            }

			Console.WriteLine($"Count of books in cart : {count}");
		}



	}
}
