using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;

namespace MyNewProject1.ThreadDemo
{
    class ThreadDemo1
    {
        public static void m1()
        {
            new CountdownEvent(100);
            //synchronisation
            for (int i = 1; i <= 30; i++)
            {
                Console.WriteLine("Odd " + i + Thread.CurrentThread.Name);
            }
        }
        static void Main(string[] args)
        {
            /*Thread main = Thread.CurrentThread;
             Thread t1 = new Thread(m1);
             t1.Name = "Om";
             Console.WriteLine("Priority ="+t1.Priority);

             //Console.WriteLine("Priority "+t1.Priority);

             Thread t2 = new Thread(m1);
             t2.Name = "Ram";
             t2.Priority = ThreadPriority.Highest;
             t1.Start();
             t2.Start();

             Thread.Sleep(1000);
             for(int i=2;i<30;i=i+2)
             {
                 Console.WriteLine(i);
             }*/
            Thread t1 = new Thread(m1);
            t1.IsBackground = true;//helper thread
            t1.Start();

            for (int i = 1; i <= 10; i++)

                Console.WriteLine("Main " + i);
            Console.WriteLine("Main Ends");
            Console.ReadLine();
        }
    }
}
