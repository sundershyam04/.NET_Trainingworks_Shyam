using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace dsa_day1
{
	public class Linkedlistdemo

	{
		static void Main(string[] args)
		{
            LinkedList<int> mylist = new LinkedList<int>();
            mylist.AddFirst(10);
            mylist.AddLast(100);
            mylist.AddAfter(mylist.First, 20);
            mylist.AddBefore(mylist.Last, 90);
            mylist.AddBefore(mylist.Last.Previous, 80);
            mylist.AddAfter(mylist.First.Next, 30);
            LinkedListNode<int> foundnode = mylist.Find(20);
            foundnode.Value = 200;



            foreach (var item in mylist)
            {
                Console.WriteLine(item);

            }
            Console.ReadKey();
        }
	}
}
