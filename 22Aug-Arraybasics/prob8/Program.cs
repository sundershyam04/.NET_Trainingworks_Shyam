using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace prob8
{
    internal class Program
    {
        static void Main(string[] args)
        {
           Hashtable ht=new Hashtable();
            //Dictionary<int,string> ht=new Dictionary<int,string>();
            ht.Add(1, "Audi");
            ht.Add(2, "BMW");
            ht.Add(3, "Mercedes Benz");
            ht.Add(4, "Hyundai");
            ht.Add(5, "honda");

            Console.WriteLine("hASh table contents:");

            foreach (DictionaryEntry d in ht)
            {
                Console.WriteLine($"key : {d.Key} \t value: {d.Value}");
            }

            Console.WriteLine("After removing and updating");
            
            ht[5] = "Kia";
            ht.Remove(4);
            ht.Remove(3);
            ht[3] = "Mini COOPER";

            foreach (DictionaryEntry d in ht)
            {
                Console.WriteLine($"key : {d.Key} \t value: {d.Value}");
            }



        }
    }
}
