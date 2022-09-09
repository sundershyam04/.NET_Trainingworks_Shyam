using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;

namespace handson_9sept
{
    internal class SempaphoreDemo
    {
        static Thread[] th = new Thread[10];

        //Semaphore Class Object Creation

        static Semaphore sem = new Semaphore(3,4);  //can initially be 3 capacity => then 3 to 4 varying 

        static  void Method1()
        {


           //wait
            Console.ForegroundColor = ConsoleColor.DarkYellow;
            Console.WriteLine($"{Thread.CurrentThread.Name}  is waiting....");


            //entry
            sem.WaitOne();

            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine($"{Thread.CurrentThread.Name}  is enters ....");
            Thread.Sleep(400);




            //exit
            sem.Release();
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine($"{Thread.CurrentThread.Name}  is leaving ....");

            //sem.Release();
        }
        static void Main(string[] args)
        {
            for (int i = 0; i < 10; i++)
            {
                th[i] = new Thread(Method1);
                th[i].Name= "Thread - " + i;
                th[i].Start();
            }

        }
    }
}
