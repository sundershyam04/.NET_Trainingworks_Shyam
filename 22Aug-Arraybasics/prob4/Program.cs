using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace prob4
{
    internal class Program
    {
        static void Main(string[] args)
        {

            ArrayList al = new ArrayList();

            al.Add("Lion");
            al.Add(100);
            al.Add("Tiger");
            al.Add(new DateTime());
            al.Add(true);
            Console.WriteLine("ArrayList elements");
            foreach (var item in al)
            {
                Console.WriteLine(item);
            }

            Console.WriteLine( "After removing");
            al.Remove(true);

            al.RemoveRange(1, 2);

            foreach (var item in al)
            {
                Console.WriteLine(item);
            }
            Console.WriteLine($"\n No.of.elements in alist:{al.Count}");







        }
    }
}
