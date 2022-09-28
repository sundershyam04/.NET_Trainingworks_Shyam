using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BusinessLogicLibraryShopping;
namespace EF_DBfirstDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            CustomerOperations co = new CustomerOperations();
            List<CustomerBAL> customers  =co.GetCustomers();

            foreach (var item in customers)
            {
                Console.WriteLine(item.custid + " " +  item.customerName + item.customerCity);
            }

            Console.WriteLine("--------------------------");
            CustomerBAL bal = new CustomerBAL();
            //Console.WriteLine("Add Customer");
            //Console.WriteLine("enter customerid");

            //bal.custid = Convert.ToInt32(Console.ReadLine());
            //Console.WriteLine("entr custname");
            //bal.customerName = Console.ReadLine();

            //Console.WriteLine("enter city");
            //bal.customerCity = Console.ReadLine();

            //co.Insertcustomer(bal);
            //Console.WriteLine("record Inserted successfully...");
            //    Console.WriteLine("---------------");
            //customers = co.GetCustomers();

            //foreach (var item in customers)
            //{
            //    Console.WriteLine(item.custid + " " + item.customerName + item.customerCity);
            //}
            //Console.WriteLine("=---------------------------");

            //Console.WriteLine("Update customer");
            //Console.WriteLine("enter custid to update");
            //bal.custid = Convert.ToInt32(Console.ReadLine());
            //Console.WriteLine("entr custname");
            //bal.customerName = Console.ReadLine();
            //Console.WriteLine("enter city");
            //bal.customerCity = Console.ReadLine();
            //co.UpdateCustomer(bal);
            //Console.WriteLine("Updated successfully....");
            //Console.WriteLine("-----------------");
            //customers = co.GetCustomers();

            //foreach (var item in customers)
            //{
            //    Console.WriteLine(item.custid + " " + item.customerName + item.customerCity);
            //}

            Console.WriteLine("Delete Customer using custid" );
            Console.WriteLine("enter custid to delete");
            int custid = Convert.ToInt32(Console.ReadLine());
            co.DeleteCustomer(custid);
            Console.WriteLine("Deleted successfully....");

            customers = co.GetCustomers();

            foreach (var item in customers)
            {
                Console.WriteLine(item.custid + " " + item.customerName + item.customerCity);
            }

            Console.WriteLine();




            Console.ReadLine();


        }
    }
}
