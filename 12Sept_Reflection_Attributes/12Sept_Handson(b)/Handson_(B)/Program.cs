using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Reflection;

namespace Handson__B_
{
    internal class Program
    {
        static void GetCustomAttr(Type t)
        {
            Console.WriteLine("Class name: " +t.FullName);

            //Reflection

            Attribute[] Attrs=System.Attribute.GetCustomAttributes(t);

            //print custom attr of class 

           
            foreach ( var attr in Attrs)
            {
                Console.WriteLine("-----Custom attr of CLASS SONGS-------------");

                if(attr is StereoDisc)
                {
                    StereoDisc s = (StereoDisc)attr;

                    Console.ForegroundColor = ConsoleColor.Green;
                    Console.WriteLine(s.SongName);
                    Console.WriteLine(s.Language);
                    Console.WriteLine(s.Lyrics);
                    Console.ForegroundColor = ConsoleColor.White;
                }
                Console.WriteLine("------------------");
              
            }
            Console.WriteLine("-------Custom attr of EACH MEMBERS OF CLASS------------");

            MemberInfo[] mi= t.GetMembers();

            foreach (var item in mi) // for traversing each members of class
            {
                Console.WriteLine(item.Name);
                System.Attribute[] attr1 = System.Attribute.GetCustomAttributes(item);

                Console.ForegroundColor= ConsoleColor.Green;
                foreach (System.Attribute attritem in attr1) //for attributes of each members
                {
                    if (attritem is StereoDisc)
                    {
                        Console.WriteLine("---------");
                        StereoDisc s1 = (StereoDisc)attritem;

                        Console.WriteLine(s1.SongName);
                        Console.WriteLine(s1.Language);
                        Console.WriteLine(s1.Lyrics);
                    }
                }
                Console.ForegroundColor = ConsoleColor.White;

                Console.WriteLine("----END OF A MEMBER-----");


            }

        }
        static void Main(string[] args)
        {

            Program.GetCustomAttr(typeof(Song));

            Console.Read();
        }
    }
}
