using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http.Headers;
using System.Text;
using System.Threading.Tasks;

namespace LOGIC
{
    public class Category
    {
      
        private int _catid;
        public int Catid
        {
            get { return _catid; }
            set { _catid = value; }
        }

        private string _catname;

        public string Name
        {
            get { return _catname; }
            set { _catname = value; }
        }


        private string _desc;

        public string Description
        {
            get { return _desc; }
            set { _desc = value; }
        }

        // Relation : 1 category --> Multiple products 

        private List<Product> _prodlist;

        public List<Product> Prodlist
        {
            get { return _prodlist; }
            set { _prodlist = value; }
        }

        public void Addcategory()
        {
            Console.WriteLine("Enter categoryid : ");
            Catid = int.Parse(Console.ReadLine());

            Console.WriteLine("Enter categoryname: ");
            Name = Console.ReadLine();

            Console.WriteLine("Enter description: ");
            Description = Console.ReadLine();
        }

        public void Displaydetails()
        {
            Console.WriteLine();
            Console.WriteLine($"CategoryID    : {Catid}");
            Console.WriteLine($"Category name : {Name}");
            Console.WriteLine($"Description   : {Description}");
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine("---------------------------------------");
            Console.WriteLine("< PRODUCTS >");
            foreach (var item in Prodlist)
            {
                Console.WriteLine($"ProductID: {item.ProdID}");
                Console.WriteLine($"Productname: {item.Name}");
                Console.WriteLine($"Quantitysold: {item.Qtysold}");
                Console.WriteLine($"Unitprice: {item.Unitprice}");
                Console.WriteLine($"Unit of measurement: {item.Unitmeasurement}");
                Console.WriteLine($"Inhand Quantity: {item.InhandQty}");
                Console.WriteLine($"reorder level :{item.Reorderlvl}");
                Console.WriteLine("-------------------------------------");
            }
            Console.ForegroundColor = ConsoleColor.White;

        }




    }
}
