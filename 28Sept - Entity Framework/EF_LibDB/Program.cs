using BAL_Library;
using System;
using System.Collections.Generic;
using System.Data.Entity.Migrations.Model;
using System.Linq;
using System.Net.NetworkInformation;
using System.Text;
using System.Threading.Tasks;

//  1) Using the Library Management System database
//  create DBFirst approach fo Books and Members table.
//  Use BAL, DAL and Console App.

namespace EF_LibraryDB
{
    internal class Program
    {
        static void Main(string[] args)
        {

            //   ENTITY FRAMEWORK db first approach

            //  ef is needed in dal and bal not compulsory in consoleapp
            Console.WriteLine("-----LIBRARY MANAGEMENT SYSTEM------");
            string ch;

            try
            {
                do
                {

                    Console.WriteLine("Menu\n1 - InsertBook\n2 - ShowBooks\n3 - Update Book\n4 - Delete Book");

                    int choice = int.Parse(Console.ReadLine());

                    switch (choice)
                    {
                        case 1  :
                                InsertBooks();
                                break;

                        case 2  :
                                 ShowBooks();
                                 break;

                        case 3  :
                                 Console.WriteLine("Enter BookNo to update");
                                 int num = int.Parse(Console.ReadLine());
                                 UpdateBooks(num);
                                 break;

                        case 4:
                                 Console.WriteLine("Enter BookName to delete");
                                 string name= Console.ReadLine();
                                 DeleteBooks(name);
                                 break;

                        default:
                                 Console.WriteLine("Enter choice from 1 to 4");
                                 break;
                    } 
                    Console.Write("Do you want to continue( yes or no ) :");
                    ch = Console.ReadLine();
                    Console.WriteLine("+++++++++++++++++++++++++++++++++++");

                } while (ch == "yes");

            }

            catch(Exception e)
            {
                Console.ForegroundColor= ConsoleColor.Red;
                Console.WriteLine(e.Message);
            }

            Console.ReadLine();

        }

        private static void InsertBooks()
        {
            Libraryoperations opr = new Libraryoperations();
            Console.WriteLine("-----INSERT BOOK-----");
            BookBAL book = new BookBAL();

            Console.WriteLine("Enter Book number");
            book.Book_No = int.Parse(Console.ReadLine());
            Console.WriteLine("Enter Book name");
            book.Book_Name = Console.ReadLine();
            Console.WriteLine("Enter author name");
            book.Author = Console.ReadLine();
            Console.WriteLine("Enter book cost");
            book.Cost = int.Parse(Console.ReadLine());
            Console.WriteLine("Enter book category");
            book.Category = Console.ReadLine();

            opr.InsertBooks(book);

            Console.WriteLine("Book inserted successfully..");

            Console.WriteLine("---------------------------");
        }

        private static void ShowBooks()
        {
            Console.WriteLine("----BOOKS-----");
            Libraryoperations opr = new Libraryoperations();
            
            List<BookBAL> books = opr.GetBooks();

            foreach (var item in books)
            {
                Console.WriteLine(item.Book_Name);
                Console.WriteLine(item.Book_No);
                Console.WriteLine(item.Author);
                Console.WriteLine(item.Cost);
                Console.WriteLine(item.Category);
                Console.WriteLine("--------------------");
            }
        }

        private static void UpdateBooks(int num)
        {
            Libraryoperations opr = new Libraryoperations();
            Console.WriteLine("------UPDATE BOOKS(type updated data)------");
            BookBAL book = new BookBAL();   
            Console.WriteLine("Enter Book name");
            book.Book_Name = Console.ReadLine();
            Console.WriteLine("Enter author name");
            book.Author = Console.ReadLine();
            Console.WriteLine("Enter book cost");
            book.Cost = int.Parse(Console.ReadLine());
            Console.WriteLine("Enter book category");
            book.Category = Console.ReadLine();

            opr.UpdateBook(num,book);

            Console.WriteLine("Updated successfully...");
            Console.WriteLine("---------------------------");

    }

        private static void DeleteBooks(string name)
        {

            Console.WriteLine("------Delete BOOK------");

            Libraryoperations opr = new Libraryoperations();

            opr.DeleteBook(name);

            Console.WriteLine("Deleted successfully...");

        }


    }
}
