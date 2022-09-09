using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;

namespace handson_9sept
{
    internal class Probs
    {
        private static void Print()
        {
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine($"==>{Thread.CurrentThread.Name} Starts...");
            Console.ForegroundColor = ConsoleColor.White;
            //----------------------------------------------------------------------
            for (int i = 1; i <= 10; i++)
            {
                Console.WriteLine($"{Thread.CurrentThread.Name} - {i}");
                Thread.Sleep(100);
            }
            //----------------------------------------------------------------------
            Console.ForegroundColor=ConsoleColor.Green;
            Console.WriteLine($"==>{Thread.CurrentThread.Name} ENDS");
            Console.ForegroundColor = ConsoleColor.White;

            //Thread.CurrentThread.Abort();

            //Console.WriteLine($"State of thread after abort : {Thread.CurrentThread.ThreadState}");
        }

        private static void Printdown()
        {
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine($"==>{Thread.CurrentThread.Name} Starts...");
            Console.ForegroundColor = ConsoleColor.White;
            //----------------------------------------------------------------------
            for (int i = 10;i>=1; i--)
            {
                Console.WriteLine($"{Thread.CurrentThread.Name} - {i}");
            }
            //----------------------------------------------------------------------
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine($"==>{Thread.CurrentThread.Name} ENDS");
            Console.ForegroundColor = ConsoleColor.White;

            //Thread.CurrentThread.Abort();

            //Console.WriteLine($"State of thread after abort : {Thread.CurrentThread.ThreadState}");
        }




        static void Main(string[] args)
        {

            Thread printnum = new Thread(new ThreadStart(Print));


            Thread printnum1 = new Thread(new ThreadStart(Print));

            printnum.Name = "PRINT_thread";

            printnum1.Name = "print_down_thread";

            Console.WriteLine($"State of {printnum.Name} before start: {printnum.ThreadState}");

            Console.WriteLine($"State of {printnum1.Name} before start: {printnum1.ThreadState}");
            Console.WriteLine($"isalive {printnum.Name} after start : {printnum.IsAlive}");

            //-----------PRIORITY-------------------


            printnum.Priority = ThreadPriority.Lowest;

            printnum1.Priority = ThreadPriority.Highest;




            //-----------------------------------------
           

            printnum.Start(); //foreground thread

            printnum1.Start();

            Console.WriteLine($"isalive {printnum.Name} after start : {printnum.IsAlive}");

            Console.WriteLine($"State of {printnum.Name} after start : {printnum.ThreadState}");

            Console.WriteLine($"State of {printnum1.Name} after start : {printnum1.ThreadState}");

            Console.WriteLine("MAIN ENDED");

            Console.WriteLine("========================");

        }
    }
}
