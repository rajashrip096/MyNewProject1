using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyNewProject1.ExceptionHandlingDemo
{
    class ExceptionPropagationdemo
    {
        static void m1()
        {
            Console.WriteLine("m1 method start");
            Console.WriteLine("Enter the number");
            int a = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("M1 ends");
        }
        public static void m2()
        {
            m1();
            Console.WriteLine("In m2222222");
        }
        static void Main(string[] args)
        {
            Console.WriteLine("Main start");
            try
            {
                m1();
            }
            catch(FormatException e)
            {
                Console.WriteLine(e.Message);
            }
            Console.WriteLine("Main ends");
            Console.ReadLine();
        }
    }
    class ExceptionProp2
    {
        static void Main(string[] args)
        {
            Console.WriteLine("main start");
            try
            {
                ExceptionPropagationdemo.m2();
            }
            catch(Exception e)
            {
                Console.WriteLine(e.Message);
            }
            Console.WriteLine("Main ends");
            Console.ReadLine();
        }
    }
}
