using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace prob7
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Queue<int> q=new Queue<int>();  
            q.Enqueue(1);   
            q.Enqueue(2);
            q.Enqueue(3);
            q.Enqueue(4);
            q.Enqueue(5);

            Console.WriteLine("Queue elements");
            Console.WriteLine($"No.of.elements: {q.Count}");
            foreach (var item in q)
            {
                Console.WriteLine(item);
            }

            q.Dequeue();
            Console.WriteLine("AfTER DEQUEUE");
            Console.WriteLine($"No.of.elements: {q.Count}");
            foreach (var item in q)
            {
                Console.WriteLine(item);
            }
            Console.WriteLine($"peek- firstitem: {q.Peek()}");
            Console.WriteLine($"Is 4 contained in q: {q.Contains(4)}");
        }
    }
}
