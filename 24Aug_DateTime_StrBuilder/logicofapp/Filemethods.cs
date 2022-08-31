using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
namespace logicofapp
{
    public class Filemethods
    {
        public static void makefile()
        {
            string p = "C:\\Users\\SHYAM SUNDER\\Desktop\\Todo\\dem.txt";
            File.Create(p);
            Console.WriteLine("file created");
        }
    }
}
