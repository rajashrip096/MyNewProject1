using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyNewProject1.Inheritance
{
    class Mobile
    {
        string memory = "64GB";
        public Mobile(int x)
        {
            Console.WriteLine("mobile memory "+memory+" "+x);
            Console.ReadLine();
        }
    }
    class Apple : Mobile
    {
        public Apple(int y):base(y)
        {
            Console.WriteLine("Apple");
            Console.ReadLine();
        }
    }
    class BaseConstructorDemo
    {
        static void Main(string[] args)
        {
            Apple a = new Apple(124);
            
        }
    }
}
