using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyNewProject1.Overriding
{
    class Apple
    {
        public virtual void show()
        {
            Console.WriteLine("Apple is sweet and healthy");
            Console.ReadLine();
        }
    }
    class Banana:Apple
    {
        public override void show()
        {
            Console.WriteLine("Banana is healthy");
            Console.ReadLine();
        }
    }
    class Fruit
    {
        static void Main(string[] args)
        {

            //Apple a = new Apple();
            //a.show();
            Apple a = new Banana();
            a.show();
           
        }
    }
}
