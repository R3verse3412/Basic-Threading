using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;

namespace Basic_Threading
{
    class MyThreadClass
    {
        public void Thread1()
        {
            for (int i = 0; i <= 5; i++)
            {
                Thread thread = Thread.CurrentThread;
                Console.WriteLine("Name of Thread: " + thread.Name + " = " + i);
                Thread.Sleep(TimeSpan.FromSeconds (1.5));
            }

        }


    }
}
