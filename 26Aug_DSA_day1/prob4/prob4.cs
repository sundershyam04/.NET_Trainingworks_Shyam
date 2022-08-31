using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace prob1
{
    internal class prob4
    {
        static void Main(string[] args)
        {
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine("===Linked List====");
            Console.ForegroundColor = ConsoleColor.White;
            LinkedList<string> llist = new LinkedList<string>(); // [             ]

            llist.AddFirst("Abishek");

            llist.AddLast("Bharath");

            //  abishek-> bharath

            llist.AddAfter(llist.First, "Dilip");

            //abishek - >Dilip ->  bharath

            llist.AddBefore(llist.Last, "Hari");


            //abishek - >Dilip ->Hari ->  bharath

            llist.AddFirst("naren");

        
            foreach (var item in llist)
            {
                Console.WriteLine(item);
            }

            Console.WriteLine("===Removing a node");

            //var fnode = llist.Find("Dilip");
            Console.WriteLine($"Removed successfully :{llist.Remove("Dilip")}.....");

            Console.ForegroundColor= ConsoleColor.Green;
            Console.WriteLine("==Final list====");

            foreach (var item in llist)
            {
                Console.WriteLine(item);
            }


        }




    }
}
