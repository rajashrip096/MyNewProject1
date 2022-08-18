using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyNewProject1.Assigment_test_Pena4
{
    ////Write a asp.net Program to find the sum of two specified times using  TimeSpan 
    class TimeSpanp7
    {
        static void Main(string[] args)
        {
            TimeSpan time;
            TimeSpan t1 = new TimeSpan(10, 20, 30);
            TimeSpan t2 = new TimeSpan(8, 19, 32);
            time = t1 + t2;

            Console.WriteLine("Hours:{0}, Minutes:{1}, Seconds:{2}", time.Hours, time.Minutes, time.Seconds);
            Console.ReadLine();
        }
    }
}
