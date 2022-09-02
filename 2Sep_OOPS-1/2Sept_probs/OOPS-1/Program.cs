using LOGIC;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOPS_1
{
    internal class Program
    {

        //static void Inputdata(Category c)
        //{
        //    List<Product> plist = new List<Product>();

        //    Console.WriteLine("Enter categoryid : ");
        //    c.Catid = int.Parse(Console.ReadLine());

        //    Console.WriteLine("Enter categoryname: ");
        //    c.Name = Console.ReadLine();

        //    Console.WriteLine("Enter description: ");
        //    c.Description = Console.ReadLine();

        //    Console.WriteLine("Enter the number of products in category");
        //    int n = int.Parse(Console.ReadLine());

        //    for (int i = 0; i < n; i++)
        //    {
        //        Product p = new Product();

        //        Console.WriteLine("Enter product ID");
        //        p.ProdID = int.Parse(Console.ReadLine());
        //        Console.WriteLine("Enter productname");
        //        p.Name = Console.ReadLine();
        //        Console.WriteLine("Enter quantity sold");
        //        p.Qtysold = int.Parse(Console.ReadLine());

        //        Console.WriteLine("Enter price of a unit");
        //        p.Unitprice = int.Parse(Console.ReadLine());
        //        Console.WriteLine("Enter measurement unit");
        //        p.Unitmeasurement = Console.ReadLine();
        //        Console.WriteLine("Enter Inhand quantity");
        //        p.InhandQty = int.Parse(Console.ReadLine());
        //        Console.WriteLine("Enter reorderlevel(high / medium / low");
        //        p.Reorderlvl = Console.ReadLine();
        //        Console.WriteLine("********************************");

        //        plist.Add(p); //Adding prod to list
        //        Product.Prodcount += 1;
        //    }
        //    c.Prodlist = plist;

        //    Console.WriteLine("===========================================");


        //}


        //static void showdetails(Category c)
        //{
        //    Console.WriteLine();
        //    Console.WriteLine($"CategoryID    : {c.Catid}");
        //    Console.WriteLine($"Category name : {c.Name}");
        //    Console.WriteLine($"Description   : {c.Description}");
        //    Console.ForegroundColor = ConsoleColor.Magenta;
        //    Console.WriteLine("---------------------------------------");
        //    Console.WriteLine("< PRODUCTS >");
        //    foreach (var item in c.Prodlist)
        //    {
        //        Console.WriteLine($"ProductID: {item.ProdID}");
        //        Console.WriteLine($"Productname: {item.Name}");
        //        Console.WriteLine($"Quantitysold: {item.Qtysold}");
        //        Console.WriteLine($"Unitprice: {item.Unitprice}");
        //        Console.WriteLine($"Unit of measurement: {item.Unitmeasurement}");
        //        Console.WriteLine($"Inhand Quantity: {item.InhandQty}");
        //        Console.WriteLine($"reorder level :{item.Reorderlvl}");
        //        Console.WriteLine("-------------------------------------");
        //    }
        //    Console.ForegroundColor = ConsoleColor.White;


        //}
        static void Main(string[] args)
        {

            //< CAT 1 >
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine("------CATEGORY 1--------");
            Console.ForegroundColor = ConsoleColor.White;


            Category c1 = new Category();

            c1.Addcategory();

            Console.WriteLine("Enter No of products in Category1: ");
            int n1=int.Parse(Console.ReadLine());

            Console.WriteLine("========================================");
            List<Product> plist1 = new List<Product>();

            for(int i = 0; i < n1; ++i)
            {
                Product p= new Product();
                p.Addproduct();
                plist1.Add(p);
            }
            c1.Prodlist = plist1;


            //< CAT 2 >
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine("------CATEGORY 2--------");
            Console.ForegroundColor = ConsoleColor.White;


            Category c2 = new Category();

            c2.Addcategory();

            Console.WriteLine("Enter No of products in Category2: ");
            int n2 = int.Parse(Console.ReadLine());
            Console.WriteLine("========================================");
            List<Product> plist2 = new List<Product>();

            for (int i = 0; i < n2; ++i)
            {
                Product p = new Product();
                p.Addproduct();
                plist2.Add(p);
            }

            c2.Prodlist=plist2;


            // DISPLAY DETAILS
            Console.WriteLine("***PRINTING DETAILS***");


            c1.Displaydetails();
            c2.Displaydetails();


            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine($"Total no of products :{Product.Prodcount}");


            //Inputdata(c1);
            //Inputdata(c2);


            //Console.WriteLine(".......Printing details......");
            //showdetails(c1);
            //showdetails(c2);


        }
    }

}
