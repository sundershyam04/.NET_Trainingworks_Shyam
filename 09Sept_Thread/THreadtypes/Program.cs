using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices.ComTypes;
using System.Text;
using System.Threading;


namespace THreadtypes
{
    internal class Program
    {


        private static void M1()
        {

            for (int i = 0; i < 5; i++)
            {
                Console.WriteLine($"VALUE : {i}");
                Thread.Sleep(1000);
            }

            Console.WriteLine("th1 thread ends");


        }
        static void Main(string[] args)
        {
             
            Thread t1=new Thread(M1);

            t1.Name = "th1";

            //t1.IsBackground = true; 
            
            //backgnd type - main goes thread goes
            
           //foregnd => main fn ends => though thred will continue till end
           
            t1.Start();

            //Thread.Sleep(6000);

            Console.WriteLine("Main fn ends");
           



        }
    }
}
