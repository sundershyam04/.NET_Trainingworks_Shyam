using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace reusablecode
{
    public class reusable_main
    {
        public static void createfile()
        {
            string path = "C:\\Users\\SHYAM SUNDER\\Desktop\\HandsOn .NET\\handon_assignments\\24Aug\\handson_task1\\reusablecode\\firstFile.txt";
            try
            {
                File.Create(path);

                Console.WriteLine("File created successfully");
            }
            catch(Exception e)
            {
                Console.WriteLine(e.Message);
            }
        }
    }
}
