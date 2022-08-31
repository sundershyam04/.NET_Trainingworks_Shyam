using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Remoting.Messaging;
using System.Runtime.Remoting.Services;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;
using static _24Aug_Task1.Linkedlist;

namespace _24Aug_Task1
{
    internal class Program
    {
      

        static void Main(string[] args)
        {
            Linked<string> l = new Linked<string>();

            l.AddFirst(new Node<string>("first"));

            l.AddFirst(new Node<string>("second"));

            l.AddLast(new Node<string>("third"));

           

            l.AddLast(new Node<string>("Fourth"));



            Node<string> tmp = new Node<string>(null);
            tmp = l.head;

            while (tmp != null)
            {

                Console.Write(tmp.data+" => ");
                tmp = tmp.next;
            }

            Console.ReadLine();
        }

        
    }
}
