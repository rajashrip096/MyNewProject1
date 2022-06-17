using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyNewProject1.Oops
{
    class ConstructorDemo
    {
        public ConstructorDemo()
        {
            Console.WriteLine("Default");
        }
        public ConstructorDemo(int x)
        {
            Console.WriteLine(x);
        }
        public void get()
        {

        }
        static void Main(string[] args)
        {
            ConstructorDemo c = new ConstructorDemo();
            ConstructorDemo c1 = new ConstructorDemo(10);
            c.get();
            Console.ReadLine();
        }
        
    }
}
