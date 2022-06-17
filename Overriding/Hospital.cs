using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyNewProject1.Overriding
{
    class Animal
    {
        string name="Dog";
        public void get(string name)
        {
            Console.WriteLine("Animal is  " +name);
        }
    }
    class Cat:Animal
    {
        string colour;
        string name = "Dog";

        public void show()
        {
            base.get("cat"  +   " white \t" + name+"");
            Console.ReadLine();
        }
    }
    class Overriding
    {
        static void Main(string[] args)
        {
            Cat c = new Cat();
            c.show();
            
        }
    }
}
