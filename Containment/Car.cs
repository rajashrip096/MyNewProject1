using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyNewProject1.Containment
{
    class SubEngine
    {
        string cleanupDate;
        public SubEngine(string cleanupDate)
        {
            this.cleanupDate = cleanupDate;
        }
        public void show()
        {
            Console.WriteLine(cleanupDate);
            Console.ReadLine();
        }
    }
    class Engine
    {
        string type;
        SubEngine sub;
        public Engine(string type,SubEngine sub)
        {
            this.type = type;
            this.sub = sub;
        }
        public void ShowEngine()
        {
            Console.WriteLine(type);
            sub.show();
            Console.ReadLine();
        }
    }
    class Car
    {
        int model;
        string name;
        int price;
        Engine e;
        Car(int model,string name,int price ,Engine e)
        {
            this.model = model;
            this.name = name;
            this.price = price;
            this.e = e;
        }
        public void showCar()
        {
            Console.WriteLine(model+"  "+name+"  "+price);
            e.ShowEngine();
            Console.ReadLine();
        }
        static void Main(string[] args)
        {
            Car c = new Car(123, "Audi", 784783, new Engine("petrol", new SubEngine("5/5/2022")));
            c.showCar();
        }
    }
}
