using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyNewProject1.Inheritance
{
    class Mobile1
    {
        string memory = "64GB";
        public Mobile1(int x,int y)
        {
            Console.WriteLine("mobile memory " + memory + " " + x);
            Console.ReadLine();
        }
    }
    class Apple1 : Mobile1
    {
        public Apple1(int y) : base(23,y)
        {
            Console.WriteLine("Apple");
            Console.ReadLine();
        }
    }
    class BaseConstructor2
    {
        static void Main(string[] args)
        {
            Apple1 a = new Apple1(124);
        }
    }
}
