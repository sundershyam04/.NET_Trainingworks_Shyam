using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Logic
{
    //public delegate void Action_edit_update_del(int empid,Department dd);

    //public delegate void Action_add();
    public class Department
	{

        public event Action_edit_update_del UpdateElist;

		public event Action_add AddEvent;

        private int _deptId;

		public int DeptId
		{
			get { return _deptId; }
			set { _deptId = value; }
		}

		private string _deptName;

		public string DeptName
		{
			get { return _deptName; }
			set { _deptName = value; }
		}

		private string _location;

		public string Location
		{
			get { return _location; }
			set { _location = value; }
		}

		private List<Employee> _elist=new List<Employee>();

		public List<Employee> Elist
        {

					get { return _elist; }

					set 
					{
				if (Elist.Count <= 10) _elist = value;

                else throw new Exception("Employee in a department should not exceed 10");
			        
				     }
		
		}

		public void getdetails()
		{
            Console.WriteLine("Enter Dept Id");
            this.DeptId = int.Parse(Console.ReadLine());

            Console.WriteLine("Enter Dept Name");
            this.DeptName = Console.ReadLine();

            Console.WriteLine("Enter Dept location");
			this.Location = Console.ReadLine();


        }

        public void showmenu()
		{
			Console.WriteLine("******************************************");

			Console.WriteLine("MENU \n1  - Add Employee from dept\n2 - Update Employee from dept\n3 - Delete Employee from dept");
            Console.WriteLine("******************************************");

        }
        //------------add----------------
        public void Add()
		{
			
			AddEvent();

		}

		public void Department_AddEvent()
		{
			Console.WriteLine("*********************************");
            Employee emp = new Employee();

			Console.WriteLine("Enter Employee Id");
			emp.EmpId = int.Parse(Console.ReadLine());

            Console.WriteLine("Enter Employee Name");
            emp.EmpName =Console.ReadLine();

            Console.WriteLine("Enter Employee dept no");
            emp.DeptNo = int.Parse(Console.ReadLine());


            Console.WriteLine("Enter Employee salary");
            emp.Salary= int.Parse(Console.ReadLine());

            Console.WriteLine("Enter manager reporting status");
			emp.Manager_rep = bool.Parse(Console.ReadLine());

            Elist.Add(emp);
			Console.ForegroundColor= ConsoleColor.Green;
			Console.WriteLine("Employee added successfully in list......");
            Console.ForegroundColor = ConsoleColor.White;
        }



		//------------------------------------

		//edit
		public void Edit()
		{

			Console.WriteLine("------EDIT OPERATION--------");
			Console.WriteLine("Enter Emplyee id to edit name ");
			int id = int.Parse(Console.ReadLine());

			UpdateElist(id,this);
		}
		//---------remove--------------------------------
	
		public void RemoveEmp()
		{
			Console.ForegroundColor=ConsoleColor.Red;
            Console.WriteLine("------Remove OPERATION--------");
            Console.WriteLine("Enter Emplyee id to REMOVE ");
            int id = int.Parse(Console.ReadLine());

            UpdateElist(id, this);

        }

	}
}
