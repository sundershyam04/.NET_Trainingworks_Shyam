using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    public class stackstore<T>
    {
        internal static readonly int max = 100;

        internal T[] stack = new T[max];

        int top;

       public bool isStackEmpty()
        {
            return top < 0;
        }

        public stackstore() // constructor
        {
         top=-1;
        }

        public T Peek()
        {
            if (top == -1) return default(T);
            else return stack[top];
      
        }

        public void Push(T data)
        {
            if (top >= max)
            {

                Console.WriteLine("No space on stack");
            }
            else
            {
                stack[++top] = data;
            
            }

        }

        public void Pop()
        {
            T val = default(T) ;
            if (top < 0)
            {
                Console.WriteLine("No elements in stack");
                return;
            }
            else
            {
                val=stack[top--];  // first assigned the decr

                Console.WriteLine(val + "=>popped out");

            }
        }

        public void printstack()
        {
            int t = top;
            if (t < 0) Console.WriteLine("No elements in stack");
            else
            {
                while (t >= 0)
                {
                    Console.WriteLine(stack[t]);
                    t--;
                }
            }
        }
    }
}
