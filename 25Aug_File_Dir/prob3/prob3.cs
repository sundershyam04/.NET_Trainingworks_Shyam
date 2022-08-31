using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.CodeDom.Compiler;

namespace prob3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string p1 = @"C:\Users\SHYAM SUNDER\Desktop\HandsOn .NET\handon_assignments\25Aug\prob3\Results";

            string p2= @"C:\Users\SHYAM SUNDER\Desktop\HandsOn .NET\handon_assignments\25Aug\prob3\Results\Results17-18";
            string p3 = @"C:\Users\SHYAM SUNDER\Desktop\HandsOn .NET\handon_assignments\25Aug\prob3\Results\Results18-19";
            string p4 = @"C:\Users\SHYAM SUNDER\Desktop\HandsOn .NET\handon_assignments\25Aug\prob3\Results\Results20-21";

            // a) create dir and subdir


            //if (!Directory.Exists(p1))
            //{
            //   DirectoryInfo di1= Directory.CreateDirectory(p1);
            //   Console.WriteLine("Directory created!");
            //}
            //if (!Directory.Exists(p2))
            //{
            //    DirectoryInfo di2 = Directory.CreateDirectory(p2);
            //    Console.WriteLine("Directory created!");
            //}
            //if (!Directory.Exists(p3))
            //{
            //    DirectoryInfo di3 = Directory.CreateDirectory(p3);
            //    Console.WriteLine("Directory created!");
            //}
            //if (!Directory.Exists(p4))
            //{
            //    DirectoryInfo di4 = Directory.CreateDirectory(p4);
            //    Console.WriteLine("Directory created!");
            //}

            // b) 2 files under each subdir

            //File.WriteAllText(Path.Combine(p2, "log1.txt"), "log1");
            //File.WriteAllText(Path.Combine(p2, "log2.txt"), "log2");

            //File.WriteAllText(Path.Combine(p3, "log1.txt"), "log1");
            //File.WriteAllText(Path.Combine(p3, "log2.txt"), "log2");

            //File.WriteAllText(Path.Combine(p4, "log1.txt"), "log1");
            //File.WriteAllText(Path.Combine(p4, "log2.txt"), "log2");

            //Console.WriteLine("Files inside Subdirectories created.........");


            // c) month wise folders in subdir

            string j =  @"\Jan";
            string f =  @"\Feb";
            string m =  @"\March";
            string a =  @"\April";
            string ma = @"\May";
            string ju = @"\June";
            string jul= @"\July";
            string au = @"\Aug";
            string s =  @"\Sept";
            string o =  @"\Oct";
            string n =  @"\Nov";
            string d =  @"\Dec";

            //1st sub -> jan to dec folders created
            //Directory.CreateDirectory(p2+j);
            //Directory.CreateDirectory(p2 + f);
            //Directory.CreateDirectory(p2 + m);
            //Directory.CreateDirectory(p2 + a);
            //Directory.CreateDirectory(p2 + ma);
            //Directory.CreateDirectory(p2 + ju);
            //Directory.CreateDirectory(p2 + jul);
            //Directory.CreateDirectory(p2 + au  );
            //Directory.CreateDirectory(p2 + s);
            //Directory.CreateDirectory(p2 + o);
            //Directory.CreateDirectory(p2 + n);
            //Directory.CreateDirectory(p2 + d);

            //2nd sub -> jan to dec folders created
            //Directory.CreateDirectory(p3 + j);
            //Directory.CreateDirectory(p3 + f);
            //Directory.CreateDirectory(p3 + m);
            //Directory.CreateDirectory(p3 + a);
            //Directory.CreateDirectory(p3 + ma);
            //Directory.CreateDirectory(p3 + ju);
            //Directory.CreateDirectory(p3 + jul);
            //Directory.CreateDirectory(p3 + au);
            //Directory.CreateDirectory(p3 + s);
            //Directory.CreateDirectory(p3 + o);
            //Directory.CreateDirectory(p3 + n);
            //Directory.CreateDirectory(p3 + d);

            //3rd sub -> jan to dec folders created
            //Directory.CreateDirectory(p4 + j);
            //Directory.CreateDirectory(p4 + f);
            //Directory.CreateDirectory(p4 + m);
            //Directory.CreateDirectory(p4 + a);
            //Directory.CreateDirectory(p4 + ma);
            //Directory.CreateDirectory(p4 + ju);
            //Directory.CreateDirectory(p4 + jul);
            //Directory.CreateDirectory(p4 + au);
            //Directory.CreateDirectory(p4 + s);
            //Directory.CreateDirectory(p4 + o);
            //Directory.CreateDirectory(p4 + n);
            //Directory.CreateDirectory(p4 + d);


            //d) Enumerate subdir 


            Console.WriteLine("========Directories Inside Results==========");

            List<string> dirs1 = new List<string>(Directory.EnumerateDirectories(p1));

            foreach (var dir in dirs1)
            {
                Console.WriteLine($"{dir.Substring(dir.LastIndexOf(Path.DirectorySeparatorChar) + 1)}");
            }
            Console.WriteLine($"{dirs1.Count} directories found.");

            //#1 - inside Results17-18

            Console.WriteLine("========Directories Inside Results17-18==========");
            List<string> dirs2 = new List<string>(Directory.EnumerateDirectories(p2));

            foreach (var dir in dirs2)
            {
                Console.WriteLine($"{dir.Substring(dir.LastIndexOf(Path.DirectorySeparatorChar) + 1)}");
            }
            Console.WriteLine($"{dirs2.Count} directories found.");

            // using same #1 we can find for Results18-19 & Results20-21 with enumeratedir //




        }
       

        }
    }

