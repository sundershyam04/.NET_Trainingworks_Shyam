using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DataAccessLayerFlipkartdemo;
using System.Data.Entity;
namespace BusinessLogicLibraryShopping
{
   public class CustomerOperations
    {

        public int CustomerCount()
        {
            FlipkartshoppingEntities context = new FlipkartshoppingEntities();
            context.


        }


        public void DeleteCustomer(int custid)
        {

            FlipkartshoppingEntities context = new FlipkartshoppingEntities();
            context.sp_CustomerDelete(custid);
            context.SaveChanges();
        }

        public void UpdateCustomer(CustomerBAL bal)
        {
            FlipkartshoppingEntities context = new FlipkartshoppingEntities();
            List<customer> customers=context.customers.ToList();
            customer obj=customers.Find(cust => cust.custid == bal.custid);
            obj.custname = bal.customerName;
            obj.city = bal.customerCity;
            context.SaveChanges();

        }

        public void Insertcustomer(CustomerBAL bal)
        {
            FlipkartshoppingEntities context = new FlipkartshoppingEntities();
            customer c = new customer();
            c.custid = bal.custid;
            c.custname = bal.customerName;
            c.city = bal.customerCity;
            context.customers.Add(c);
            context.SaveChanges();

        }



        public List<CustomerBAL> GetCustomers()
        {
            FlipkartshoppingEntities context = new FlipkartshoppingEntities();

            List<customer> clist = context.customers.ToList();
            List<CustomerBAL> cblist = new List<CustomerBAL>();
            foreach (var item in clist)
            {
                cblist.Add(new CustomerBAL { custid = item.custid, customerName = item.custname, customerCity = item.city });



            }
            return cblist;


            

        }




    }
}
