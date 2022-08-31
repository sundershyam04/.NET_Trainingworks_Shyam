using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //    < Stack generic classes >

            stackstore<int> st = new stackstore<int>();
            Console.WriteLine("======STACK=====");

            Console.WriteLine($"Is stack empty :{st.isStackEmpty()}");
          

            st.Push(10);
            st.Push(20);
            st.Push(30);
            st.Push(40);
            st.Push(50);
            Console.WriteLine("===STACK ELEMENTS PRINT===");

            st.printstack();

            Console.WriteLine("==POP==");

            st.Pop();
            st.Pop();  // 2 ELEMENTS REMOVED

            Console.WriteLine("===STACK ELEMENTS PRINT===");

            st.printstack();

            Console.WriteLine("=====TOP ELEMENT====");

            Console.WriteLine($"Top element : {st.Peek()}");









        }
    }
}
