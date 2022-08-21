using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyNewProject1.Delegate
{
    public delegate void mydele();
    public delegate int mydele2(int a, int b);
    class Delegated1
    {
        public static int Add(int a, int b)
        {
            Console.WriteLine("Add = " + (a + b));
            return a + b;
        }
        static void greet()
        {
            Console.WriteLine("Good Morning");
        }
        static void Main(string[] args)
        {
            mydele d1 = greet;
            d1();
            mydele2 d2 = Add;
            d2(10, 20);
            Console.ReadLine();

        }
    }
}
