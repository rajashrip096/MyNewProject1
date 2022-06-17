
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyNewProject1.Oops
{
    // write the code to show constructor overloading
    class ConstructorOverloading
    {
        public  ConstructorOverloading()
        {
            Console.WriteLine("hello");
            Console.ReadLine();
        }
        public ConstructorOverloading(int x)
        {
            Console.WriteLine(x);
            Console.ReadLine();
        }
        
        static void Main(string[] args)
        {
            ConstructorOverloading c2 = new ConstructorOverloading();
            ConstructorOverloading c1 = new ConstructorOverloading(45);
           

        }
    }
}
