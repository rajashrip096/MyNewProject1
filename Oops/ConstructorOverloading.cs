
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
    class Constructorcp
    {
        string name;
        int x;
        public Constructorcp(string name,int x)
        {
            this.name = name;
            this.x = x;
        }
        public Constructorcp(Constructorcp cp)
        {
            name = cp.name;
            x = cp.x;
        }
        public string show()
       {
            return ""+name+" "+x.ToString();    
       }
        
    }
    class C1
    {
        static void Main(string[] args)
        {
            Constructorcp c1 = new Constructorcp("C# copy Constructor", 10);
            Constructorcp c2 = new Constructorcp(c1);
            c2.show();
            Console.ReadLine();

        }
    }
}
