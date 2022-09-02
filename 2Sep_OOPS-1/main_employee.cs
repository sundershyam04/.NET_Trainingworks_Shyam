using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2Sep_OOPS_1
{
    internal class main_employee
    {
        static void Main(string[] args)
        {
            Employee emp = new Employee();

            emp.Employeeid = 112;
            emp.Title = "Software architect";
            emp.JoiningDate = new DateTime(22, 09, 01);
            emp.FirstName = "Ram";
            emp.LastName = "kumar";

            Address add=new Address();
            add.ApartmentName = "Ganga";
            add.Area = "220sqft";
            add.HouseNo = 11;
            add.StreetNo = 12 / 1;

            emp.EmpAddress = add;

            Clubs cl1=new Clubs();

            cl1.Clubname = "Sangam";
            cl1.Domain = "Music";

            Clubs cl2=new Clubs();

            cl2.Clubname = "Twisters";
            cl2.Domain = "Dance";

            List<Clubs> l=new List<Clubs> { cl1, cl2 };

            emp.Club = l;

            emp.showdetails();
           
        }

    }
}
