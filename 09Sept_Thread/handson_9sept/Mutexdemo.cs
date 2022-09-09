using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace handson_9sept
{
    internal class Mutexdemo
    {

        static void Main(string[] args)
        {
            //imterprocess
            using (Mutex mutex = new Mutex(false, "MutexDemo"))
            {

                if (!mutex.WaitOne(1000, false))
                {
                    Console.WriteLine("Already running....");
                    Console.ReadLine();
                    return;

                }
                else
                {
                    Console.WriteLine("App is running");
                    Console.ReadLine();
                }

            }
        }
    }
}
