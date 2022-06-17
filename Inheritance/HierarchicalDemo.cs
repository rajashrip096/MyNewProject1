using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyNewProject1.Inheritance
{
    class Laptop
    {
        public string memory = "500GB";
    }
    class Dell : Laptop
    {
        public string RAM = "16GB";
    }
    class Accer : Laptop
    {
        public string camera = "3.5px";
    }
    class Hp : Laptop
    {
        public string screen = "32inch";
    }
    class HierarchicalDemo
    {
        static void Main(string[] args)
        {
            Dell d = new Dell();
            Console.WriteLine("Dell  "+d.memory+" "+d.RAM);
            Hp h = new Hp();
            Console.WriteLine("Hp "+h.memory+" "+h.screen);
            Accer a = new Accer();
            Console.WriteLine("accer "+a.memory+" "+a.camera);
            Console.ReadLine();
        }
    }
}
