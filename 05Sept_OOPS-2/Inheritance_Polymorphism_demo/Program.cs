using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Logic_definitions;

namespace Inheritance_Polymorphism_demo
{
    internal class Program
    {
        static void Main(string[] args)
        {

            List<Book> blist = new List<Book>();

            Console.WriteLine("Enter Category ID");
            int id = int.Parse(Console.ReadLine());
            Console.WriteLine("Enter Category Name");
            string name =Console.ReadLine();
            Console.WriteLine("Enter Category description");
            string desc = Console.ReadLine();


            BookCategory bc = new BookCategory(id,name,desc);
            Console.WriteLine("============================");

            Console.WriteLine("Enter no of books to be inserted:");

            int n = int.Parse(Console.ReadLine());

            for (int i = 0; i < n; i++)
            {
                Console.WriteLine("---------------------------");
                Book  b= new  Book();
                Console.WriteLine("Enter Book ID");
                int bid = int.Parse(Console.ReadLine());
                Console.WriteLine("Enter Book Name");
                string bname = Console.ReadLine();
                Console.WriteLine("Enter Book price");
                float bprice = float.Parse(Console.ReadLine());

                b.Insertbook(bid, bname, bprice, b);

                blist.Add(b);
                Console.ForegroundColor = ConsoleColor.Green;
                Console.WriteLine("=>Added successfully....");
                Console.ForegroundColor = ConsoleColor.White;

            }

            Novel nnew = new Novel();
            nnew.Insertbook(25, "agastha christie", 899,1056);

            blist.Add(nnew);

            bc.Cblist = blist;

            //cart 

            Cart c=new Cart();


            foreach (var item in blist)
            {
                c.AddToCart(item);
            }

            c.DisplayCart();




        }
    }
}
