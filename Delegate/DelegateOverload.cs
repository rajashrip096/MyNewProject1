using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyNewProject1.Delegate
{
    public delegate void mydele3(int a);
    class DelegateOverload
    {
        public static void m1(int a)
        {
            Console.WriteLine("in m1 " + a);
        }
        public static void square(int n)
        {
            Console.WriteLine("Square " + n * n);
        }
        static void Main(string[] args)
        {
            //mydele3 d1 = square; //SingleCast

            //Multi -Cast holding reference of more than one function
            mydele3 d2 = square;
            d2 = d2 + m1;
            d2(9);
            Console.ReadLine();
        }
    }
}
