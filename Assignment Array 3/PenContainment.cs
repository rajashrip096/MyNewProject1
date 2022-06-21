using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyNewProject1.Assignment_Array_3
{
    class Nib
    {
        string materialtype;
        int width;
        public Nib(string materialType ,int width)
        {
            this.materialtype = materialType;
            this.width = width;
        }
        public void show()
        {
            Console.WriteLine(materialtype+" "+width);
            Console.ReadLine();
        }
    }
    class Refill
    {
        string inkColour;
        int length;
        string nib;
        Nib n;
        public Refill(string inkColour,int length,string nib,Nib n)
        {
            this.inkColour = inkColour;
            this.length = length;
            this.nib = nib;
            this.n = n;
        }
        public void showRifill()
        {
            Console.WriteLine(inkColour+" "+length+" "+nib);
            n.show();
            Console.ReadLine();
        }
    }
    class PenContainment
    {
        int capLength;
        string brand;
        Refill r;
        //Nib n;
        PenContainment(int capLength, string brand,Refill r)
        {
            this.capLength = capLength;
            this.brand = brand;
            this.r = r;
        }
        public void showPenContainment()
        {
            Console.WriteLine(capLength+" "+brand);
            r.showRifill();
            Console.ReadLine();
        }
        static void Main(string[] args)
        {
            PenContainment p = new PenContainment(10, "cello", new Refill("Red",1, "Metal", new Nib("Plastic", 11)));
            p.showPenContainment();
            Console.ReadLine();
        }
    }
}
