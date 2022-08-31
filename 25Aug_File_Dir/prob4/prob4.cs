using System;
using System.IO;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace prob4
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("======All drives info========");
            DriveInfo[] drive = DriveInfo.GetDrives();

            foreach (var item in drive)
            {
                Console.WriteLine($"==========={item.Name}==============");
                Console.WriteLine(item.DriveType);
                Console.WriteLine( item.VolumeLabel);
                Console.WriteLine(item.TotalSize);
                Console.WriteLine(item.AvailableFreeSpace);
                Console.WriteLine(item.DriveFormat);
                Console.WriteLine(item.IsReady);
               
            }
           
            Console.WriteLine("============E dRIVE INFO separate=================");

            DriveInfo di = new DriveInfo("E");

            Console.WriteLine(di.Name);
            Console.WriteLine(di.DriveType);
            Console.WriteLine(di.VolumeLabel);
            Console.WriteLine(di.TotalSize);
            Console.WriteLine(di.AvailableFreeSpace);
            Console.WriteLine(di.DriveFormat);        
            Console.WriteLine(di.RootDirectory);
            Console.WriteLine("=============================");


        }
    }
}
