using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyNewProject1.Overriding
{
    class Vehical
    {
        public void run()
        {
            Console.WriteLine("vehical is Running....");
            Console.ReadLine();
        }
    }
    class Car : Vehical
    {
        public void run()
        {
            Console.WriteLine("car is Running........");
            Console.ReadLine();
        }
    }
    class Truck:Vehical
    {
        public void run()
        {
            Console.WriteLine("truck is Running.....");
        }
    }
    class OverridingDemo
    {
        static void Main(string[] args)
        {
            Car c = new Car();
            c.run();
            Vehical v = new Car();
            v.run();
            v = new Truck();
            v.run();
            Console.ReadLine();

        }
    }
}
