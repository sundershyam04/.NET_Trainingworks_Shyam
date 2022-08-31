using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Linkedlist_stack_queue
{
    public class UserStack
    {
        internal static readonly int max = 1000;
        internal int[] stack = new int[max];
        int top;

       public bool isStackEmpty()
        {
            //bool status = false;
            //if (top<0)
            //{
            //    status = true;
            //}
            //return status;
            return (top < 0);
        }

        public UserStack()
        {
            top = -1;
        }

        public void Push(int data)
        {
            if (top >= max)
            {
                Console.WriteLine("No space on the stack");
                return;
            }
            else
            {
                stack[++top] = data;

            }
        }

       public void Pop()
        {
            int value = 0;
            if (top < 0)
            {
                Console.WriteLine("No elements on the stack");
                return;
            }
            else
            {
                value = stack[top--];
                Console.WriteLine(value);
            }
        }
        public void Peek()
        {
            if (top < 0)
            {
                Console.WriteLine("No elements on the stack");
                return;
            }
            else
            {
                int value = stack[top];
                Console.WriteLine(value);
            }
        }

        public void PrintStackElements()
        {
            if (top < 0)
            {
                Console.WriteLine("No elements on the stack");
                return;
            }
            else
            {
                for (int i = top; i >= 0; i--)
                {
                    Console.WriteLine(stack[i]);
                }
            }
        }
    }
}
