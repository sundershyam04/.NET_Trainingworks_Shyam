using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;


namespace Prob1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter filename to be created: ");
            string s = Console.ReadLine();
            
            //Initialise file and writer stream 

            FileStream fs = null;
            StreamWriter sw = null;
            Console.WriteLine("===================================");
            Console.WriteLine("Enter 1 for Filecreation and write\n2 for Truncate file");
            Console.WriteLine("Enter the choice :");
            int choice = int.Parse(Console.ReadLine());

            switch (choice)
            {
                case 1:     FileCreateWrite(s, ref fs, ref sw);
                            break;
                case 2:     Truncatefile(s, ref fs, ref sw);
                            break;
            }

        }

        private static void FileCreateWrite(string s, ref FileStream fs, ref StreamWriter sw)
        {
            try
            {
                fs = new FileStream(s, FileMode.OpenOrCreate,FileAccess.Write);

                //edit
                sw = new StreamWriter(fs);

                Console.WriteLine("Enter string contents :");
                string cont = Console.ReadLine();

                sw.WriteLine(cont);
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }
            finally
            {
                sw.Close();
                fs.Close();
                
                Console.WriteLine("===================================");
            }
        }

        private static void Truncatefile(string s, ref FileStream fs, ref StreamWriter sw)
        {
            Console.WriteLine("enter true for truncate");

            bool g = bool.Parse(Console.ReadLine());
            StreamReader sr = null;
            if (g)
            {

                fs = new FileStream(s, FileMode.Truncate, FileAccess.ReadWrite);

                sw = new StreamWriter(fs);

                sr = new StreamReader(fs);

                Console.WriteLine(sr.ReadToEnd());
            }
            else
            {
                Console.WriteLine("no truncate");
            }
            fs.Close();
           
            sw.Close();
            
            sr.Close();
            

        }
    }
}
