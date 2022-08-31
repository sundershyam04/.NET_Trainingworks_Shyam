using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Web;
using System.Security.Cryptography;

namespace prob2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Console.WriteLine("Enter the file name to be created :");

            //string name= Console.ReadLine();

            //string path = "C:\\Users\\SHYAM SUNDER\\Desktop\\HandsOn .NET\\handon_assignments\\25Aug\\prob2\\";

            //string fname = String.Concat(path,name);
            //File.Create(fname);
            //string s = "hi hello welcome\n";
            //File.AppendAllText(fname, s);

            //Console.WriteLine("Successfully appended text");

            //Console.WriteLine("==========Filecopy==========");
            //File.Copy(fname, "hellomysore.txt"); // to bin folder

            //string p = "C:\\Users\\SHYAM SUNDER\\Desktop\\HandsOn .NET\\handon_assignments\\25Aug\\prob2\\copy\\newfoldcopy.txt";
            //File.Copy(fname, p); // to copy folder

            //Console.WriteLine(  "copied Successfully");

            //Console.WriteLine("==========Filemove==========");
            //string movpath = "C:\\Users\\SHYAM SUNDER\\Desktop\\HandsOn .NET\\handon_assignments\\25Aug\\prob2\\movdemo.txt";
            //File.Move(fname,movpath);  // main.txt file moved to movedemo.txt

            //Console.WriteLine("Moved successfully");
            //Console.WriteLine("========================");
            //File.Create("deletedemo.txt");

            //File.Delete("deletedemo.txt");
            //Console.WriteLine("DELETED SUCCESSFULLY");
            //Console.WriteLine("===================================");

            Console.WriteLine("========FileINfo===============");

            FileInfo info = new FileInfo("hellomysore.txt");
            Console.WriteLine($"Extension : {info.Extension}");
            Console.WriteLine($"Creation time: {info.CreationTime}");
            Console.WriteLine($"Dir name: {info.DirectoryName}");
            //Console.WriteLine(info.FullName);
            //Console.WriteLine(info.Name);
            //Console.WriteLine(info.Length);
            


        }
    }
}
