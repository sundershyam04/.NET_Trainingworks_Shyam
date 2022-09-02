using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2Sep_OOPS_1
{
    internal class main_car
    {
        static void Main(string[] args)
        {
            Car c1=new Car();

            c1.Model = 2019;
            c1.Name = "Honda";
            c1.Maxspeed = 300;

            c1.run(220f);

            c1.showdetails();



        }
    }
}
