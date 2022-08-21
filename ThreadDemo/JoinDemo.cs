using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;


namespace MyNewProject1.ThreadDemo
{
    class JoinDemo
    {
        static void m1()
        {
            for (int i = 1; i <= 20; i++)
            {
                Thread.Sleep(1000);//wait 1 mili second
                Console.WriteLine(i);
            }
        }
        static void Main(string[] args)
        {
            Console.WriteLine("Main Start");
            Thread t1 = new Thread(m1);
            t1.Start();
            //The currently thread which is executing the method
            //will wait till t1 thread completes it's logic
            t1.Join();
            for (int i = 200; i <= 220; i = i + 2)
                Console.WriteLine("Main " + i);
            Console.ReadLine();

        }
    }
}
