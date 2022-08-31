using Classdefn;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace arrayofobjects
{
    internal class objlinkedlisst
    {

        static void Main(string[] args)
        {
            LinkedList<Employee1> ll = new LinkedList<Employee1>();

            ll.AddFirst(new Employee1 { EmpID = 1, EmpName = "Jack", City = "Pune", DeptNo = 2 });

            ll.AddLast(new Employee1 { EmpID = 2, EmpName = "Jim", City = "Chennai", DeptNo = 3 });
            ll.AddBefore(ll.Last, new Employee1 { EmpID = 3, EmpName = "Jill", City = "Bangalore", DeptNo = 4 });

            // jack jill jim

            ll.AddBefore(ll.Last, new Employee1 { EmpID = 4, EmpName = "Hari", City = "Bangalore", DeptNo = 5 });

            // jack jill hari jim

            ll.AddBefore(ll.Last.Previous, new Employee1 { EmpID = 5, EmpName = "Pari", City = "Bangalore", DeptNo = 6 });
            

            // jack jill pari hari jim
         

            
            ll.Remove(ll.Last);
            // jack jill pari hari

            ll.AddLast(new Employee1 { EmpID = 6, EmpName = "Veena", City = "Bangalore", DeptNo = 7 });

            // jack jill pari hari Veena






            foreach (var item in ll)
            {
                Console.WriteLine(item.EmpName);
            }


        }
    }
}