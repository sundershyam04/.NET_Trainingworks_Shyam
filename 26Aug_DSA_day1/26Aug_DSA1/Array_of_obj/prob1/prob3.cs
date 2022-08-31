using products_prob3;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace prob1
{
    internal class prob3
    {
        static void Main(string[] args)
        {

            List<Products> list = new List<Products>();  //  [           ]  list created


            Console.WriteLine("Enter no of products to be added:");
            int n = int.Parse(Console.ReadLine());

            //1-Add products
            for (int i = 0; i < n; i++)
            {
                Addproduct(list);
            }
            Console.WriteLine("Displaying list......");

            displaylist(list);
            
            //2-Removeproducts 

            Removeproduct(list);

            Console.WriteLine("Displaying Final list......");

            displaylist(list);

            Console.Read();
        }

        private static void Removeproduct(List<Products> list)
        {
            Console.WriteLine("Enter prodId to be deleted");
            int id = int.Parse(Console.ReadLine());
            //Products p2=new Products();
            //p2.ProdName = "havells";
            //p2.ProdId = 3;
            //list.Add(p2);
            
            Products r= list.Find(s => s.ProdId == id);
            Console.WriteLine($"Removed successfully:{list.Remove(r)} ");
        }

        private static void displaylist(List<Products> list)
        {
            foreach (var item in list)
            {

                Console.WriteLine(item.ProdName);
                Console.WriteLine(item.ProdId);
                Console.WriteLine("=============");

            }
        }

        private static void Addproduct(List<Products> list)
        {
            Products p1 = new Products();

            Console.WriteLine("Enter Product name: ");
            p1.ProdName = Console.ReadLine();

            Console.WriteLine("Enter Product Id: ");
            p1.ProdId = int.Parse(Console.ReadLine());
            list.Add(p1);

            Console.WriteLine("===Added===");
        }

        


    }
    }

