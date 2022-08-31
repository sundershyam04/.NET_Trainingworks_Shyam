using System;
using System.Collections.Generic;


namespace prob6
{
    internal class Program
    {
     
        static void Main(string[] args)
        {
            Stack<int> st = new Stack<int>();
            st.Push(10);
            st.Push(205);
            st.Push(300);
            st.Push(400);
            st.Push(500);
            Console.WriteLine($"No.of.elements in stack:" + st.Count);
            Console.WriteLine("STACK ELEMENTS");
                   
            foreach (var item in st)
            {
                Console.WriteLine(item + "\t");
            }

            Console.WriteLine($"top element:"+  st.Peek());
            st.Pop();
            st.Pop();
            
            Console.WriteLine("After pop");
            foreach (var item in st)
            {
                Console.WriteLine(item + "\t");
            }

            Console.WriteLine($"top element:" +   st.Peek());

            Console.WriteLine($"No.of.elements in stack:" + st.Count);
            Console.ReadLine();
        }
    }
}


