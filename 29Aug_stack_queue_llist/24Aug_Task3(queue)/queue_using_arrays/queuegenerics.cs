using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace queue_using_arrays
{
    internal class queuegenerics<T>
    {
        static int max = 10;

        T[] queue = new T[max];
        int front, rear;

        public queuegenerics()
            {
             front = -1;
             rear = -1;

            }


        public bool isfull()
        {
            return rear == max - 1;

        }

        public bool isempty()
        {
            return (front == -1 && rear == -1);

        }

        public T peek()
        {
            if (front == -1 && rear == -1)
            {
                return default(T);
            }
            else
            {
                return queue[front];
            }
        }

        public void enqueue(T data)
        {

            if (rear == max - 1) { Console.WriteLine("Overflow"); }

            else
            {

                if (front == -1)
                {
                    front = 0;                
                }
                
                queue[++rear] = data;           // imp....

            }
        }
        public void dequeue()
        {

            //if (this.isempty() == false && front == -1) { front = 0; }

            if(front ==-1 && rear ==-1)
            {
                Console.WriteLine("underflow error");
            }
            else if (front == rear)
            {
                front = rear = -1;
            }
            else
            {
                Console.WriteLine($"{queue[front]} => removed");
                front += 1;
            }

        }

        public  void print()
        {
            for(int i = front; i <= rear; i++)
            {

                Console.WriteLine(queue[i]);
            }
        }




    }
}
