using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Logic
{

	//delegate declaration 

	public delegate void Action_edit_update_del(int empid, Department dd);

	public delegate void Action_add();
	 //event
    public class Employee
    {
  
        private int _empId;

		public int EmpId
		{
			get { return _empId; }
			set { _empId = value; }
		}

		private string _empName;

		public string EmpName
		{
			get { return _empName; }
			set { _empName = value; }
		}

		private int _deptNo;

		public int DeptNo
		{
			get { return _deptNo; }
			set { _deptNo = value; }
		}

		private int _sal;

		public int Salary
		{
			get { return _sal; }
			set { _sal = value; }
		}

		private bool _mgr;

		public bool Manager_rep
		{
			get { return _mgr; }
			set { _mgr = value; }
		}






	}
}
