using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyNewProject1.AbstrctandInterface
{
    abstract class Vehical1
    {
        public int x = 10;
        public static int y = 80;
        public abstract void run(); //abstract method

    public Vehical1(string name)    //Constructor
    {
         Console.WriteLine("CarName  "+name);
    }
    
        //method
    public void show()
    {
        Console.WriteLine("show method");
    }
    }   
class Car1: Vehical1
{
        int x = 20;
        //Constructor calling
    public Car1():base("Audi")
    {
        Console.WriteLine("Mycar");
    }
        //method overriding
    public override void run()
    {
        Console.WriteLine("Car is Running....."+x+" "+y+" "+base.x);
    }
}
    class AbstractDemoUsingConstructor
    {
        static void Main(string[] args)
        {
            Vehical1 v1 = new Car1();
            v1.run();
            v1.show();
            Console.ReadLine();

        }
        
    }
}
