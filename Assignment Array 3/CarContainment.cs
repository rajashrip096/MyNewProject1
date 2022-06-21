using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyNewProject1.Assignment_Array_3
{
    class Gear
    {
        string type;
        public Gear(string type)
        {
            this.type = type;
        }
        public void showGear()
        {
            Console.WriteLine(type);
        }
    }
    class SubEngine
    {
        string subenginetype;
        Gear g;
        public SubEngine(string subenginetype,Gear g)
        {
            this.subenginetype = subenginetype;
            this.g = g;
        }
        public void showSubEngine()
        {
            Console.WriteLine(subenginetype);
            g.showGear();
        }
    }
    class Engine
    {
        int eid;
        string lastenginecleandate;
        SubEngine sub;
        public Engine(int eid,string lastenginecleandate,SubEngine sub)
        {
            this.eid = eid;
            this.lastenginecleandate = lastenginecleandate;
            this.sub = sub;
        }
        public void showEngine()
        {
            Console.WriteLine(eid+" "+lastenginecleandate);
            sub.showSubEngine();
        }
    }
    class CarContainment
    {
        int carid;
        string carcolour;
        Engine e;
        public CarContainment(int carid,string carcolour,Engine e)
        {
            this.carid = carid;
            this.carcolour = carcolour;
            this.e = e;
        }
        public void show()
        {
            Console.WriteLine(carid+" "+carcolour);
            e.showEngine();
        }
        static void Main(string[] args)
        {
            CarContainment c = new CarContainment(101, "Red", new Engine(1, "20/06/2022", new SubEngine("petrol", new Gear("auto manual"))));
            c.show();
            Console.ReadLine();
           
           


        }
    }
}
