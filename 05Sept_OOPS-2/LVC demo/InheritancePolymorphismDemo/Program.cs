using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ClassLibrary1;
namespace InheritancePolymorphismDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            // Products p = new Products();

            // ElectronicProducts p2 = new ElectronicProducts();//base of ElectronicsProductClass ie. Default constructor of Product
            ElectronicProducts ep = new ElectronicProducts(1, "Battery", 4000.00f);

            ElectronicProducts p1 = new ElectronicProducts(1);
            //base of Electronics ie Products Parameterised
            p1.AcceptData();
            p1.AcceptData();

            List<Products> plist = new List<Products>();
            plist=p1.ProductList();

            foreach (var item in plist)
            {
                Console.WriteLine(item.ProductID);
                Console.WriteLine(item.ProductName);
            }

            Console.ReadKey();
                

        }
    }
}
