using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyNewProject1.AbstrctandInterface
{
    abstract class Vehical
    {
        public abstract void run();//incomplete method
    }
    class Car:Vehical
    {
        public override void run()
        {
            Console.WriteLine("Car is Running.....");
        }
    }
    class AbstrctDemo
    {
        static void Main(string[] args)
        {
            Vehical v = new Car();
            v.run();
            Console.ReadLine();
        }
    }
}
