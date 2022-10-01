using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL
{
    public class course
    {
        public int courseid { get; set; }

        public string coursename { get; set; }

        public string deptid { get; set; }


        //<summary>
        //duration : in hours (example: 2.4 hrs)
        //</summary>
        public int duration { get; set; }

    }
}
