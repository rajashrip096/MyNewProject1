using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyNewProject1.Inheritance
{
    class Animal
    {
        public int legs = 0;
        public void display()
        {
            Console.WriteLine("Animal");
            Console.ReadLine();
        }
    }
    class Dog : Animal
    {
        public void show()
        {
            legs = 4;
            Console.WriteLine(legs);
            Console.ReadLine();
        }
    }
    class InheritanceDemo
    {
        static void Main(string[] args)
        {
            Dog d = new Dog();
            d.show();
            d.display();
            Console.ReadLine();
        }
        
    }
}
