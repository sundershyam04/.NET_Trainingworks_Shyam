using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DAL;
using BLL;

namespace HELPER
{
    public class HelperClass
    {
        DALclass dal = null;
        public HelperClass()
        {
            dal = new DALclass();
        }

        public bool Insert(course c1)
        {

            return dal.Insertcourse(c1);

        }

        public bool Insertstud(Student s1)
        {

            return dal.Insertstudent(s1);

        }
    }
}
