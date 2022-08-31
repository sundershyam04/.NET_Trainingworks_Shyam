using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _24Aug_Task1
{

    class Linkedlist
    {
        internal class Node<T>
        {
            public T data;
            public Node<T> next;
            private int n;

            public Node(T data)
            {
                this.data = data;
                
            }
        }

        public class Linked<T> {

            public Node<T> head;
            //public Node<T> tail;

            public void AddFirst(Node<T> n)
            {
                if (head == null)
                {
                    head = n;
                }
                else
                {
                    n.next = head;
                    head = n;
                }
            }

            public void AddLast(Node<T> node)
            {
                Node<T> temp=head;

                 while(temp.next!=null)
                {
                    temp = temp.next;

                }

                 temp.next = node;
            }

           


        }
        
        }




    }

