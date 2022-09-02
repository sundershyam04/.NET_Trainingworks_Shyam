using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2Sep_OOPS_1
{
    internal class Employee
    {
        int _empid;
        string _title;

        Address _address;

        List<Clubs> _clubs;
        public List<Clubs> Club
        {
        set { _clubs=value;}
        get { return _clubs;}

        }

        public int Employeeid
            {
                set { _empid = value; }
                get { return _empid; }

            }

            private DateTime _joiningDate;

            public DateTime JoiningDate
            {
                get { return _joiningDate; }
                set { _joiningDate = value; }
            }


            public string Title
            {
                set { _title = value; }
                get { return _title; }
            }

            private string _fname;

            public string FirstName
            {
                get { return _fname; }
                set { _fname = value; }
            }

            private string _lname;

            public string LastName
            {
                get { return _lname; }
                set { _lname = value; }
            }

            public Address EmpAddress
            {
                set { _address = value; }
                get { return _address; }
            }

            public Employee()
            {

            }

            public Employee(int empid)
            {
                _empid = empid;
            }
          public void showdetails()
        {
            Console.WriteLine($"Employee ID :{Employeeid}");
            Console.WriteLine($"Joining date :{JoiningDate}");
            Console.WriteLine($"Title :{Title}");
            Console.WriteLine($"Firstname :{_fname}");
            Console.WriteLine($"Lastname :{LastName}");
            Console.WriteLine("--------Address-----");
            Console.WriteLine($"Street no :{EmpAddress.StreetNo}");
            Console.WriteLine($"Houseno:{EmpAddress.HouseNo}");
            Console.WriteLine($"Apartment name :{EmpAddress.ApartmentName}");
            Console.WriteLine($"Area :{EmpAddress.Area}");
            Console.WriteLine("-------Club details------");
            foreach (var item in Club)
            {
                Console.WriteLine($"Clubname: { item.Clubname}");
                Console.WriteLine($"Domain of club : {item.Domain}");
                Console.WriteLine("**********************");
            }

        }

    }
    public class Clubs 
    {
        public string Clubname { get; set; }
        public string Domain { get; set; }
    }



    public class Address
        {
            int _streetno;
            public int StreetNo
            {
                get { return _streetno; }
                set { _streetno = value; }
            }
            int _houseno;
            public int HouseNo
            {
                get { return _houseno; }
                set { _houseno = value; }
            }
            string _apartname;
            public string ApartmentName
            {
                get { return _apartname; }
                set { _apartname = value; }
            }

            string _area;
            public string Area
            {
                get { return _area; }
                set { _area = value; }
            }


            //string _city;
            //string _state;
            //long _pincode;

        }

    }


