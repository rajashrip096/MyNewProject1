using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;

namespace MyNewProject1.ThreadDemo
{
    class Program
    {
        //Thread
        //single thread environment
        static void m1()
        {
            for (int i = 1; i < -1000; i++)
            {
                Console.WriteLine(i);
            }
        }
        static void Main(string[] args)
        {
            Console.WriteLine("Main Starts");
            Thread t1 = new Thread(m1);
            t1.Start();
            //m1();
            for (int i = 1; i <= 1000; i++)
            {
                Console.WriteLine("Gm");
            }
            Console.WriteLine("Main Ends");
        }
    }
}
