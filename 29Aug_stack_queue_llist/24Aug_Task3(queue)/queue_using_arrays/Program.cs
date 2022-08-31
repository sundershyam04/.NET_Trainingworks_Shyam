using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace queue_using_arrays
{
    internal class Program
    {
        static void Main(string[] args)
        {

            Console.WriteLine("====QUEUE USING GENERIC CLASS====");

            queuegenerics<string> q=new queuegenerics<string>();

            Console.WriteLine($"Is queue full  ? : {q.isfull()}");

            Console.WriteLine($"Is queue empty ? : {q.isempty()}");


            q.enqueue("apple");

            q.enqueue("banana");

            q.enqueue("Kiwi");

            q.enqueue("grapes");

            q.enqueue("pineapple");

            q.enqueue("mango");

            q.enqueue("Fig");

            Console.WriteLine("=====Printing queue elements=====");
            q.print();

            Console.WriteLine("====dequeue====");

            q.dequeue();

            q.dequeue();

            Console.WriteLine("=====Printing queue elements=====");
            q.print();

            Console.WriteLine("===peek (FRONT) element");

            Console.WriteLine($"Front element: {q.peek()}");






        }
    }
}
