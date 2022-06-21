using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyNewProject1.Assignment_Array_3
{
    class Nib1
    {
        string materialType;
        int width;
        public string MaterialType
        {
            get;
            set;
        }
        public int Width
        {
            get;
            set;
        }
    }
    class Refill1
    {
        string inkcolour;
        int length;
        Nib1 n;
        public string Inkcolour
        {
            get { return inkcolour; }
            set { inkcolour = value; }
        }
        public int Length
        {
            get;
            set;
        }
        public Nib1 N
        {
            get;
            set;
        }
    }
    class PenContainmentgeterseter
    {
        int caplength;
        string brand;
        Refill1 r;
        
        public int Caplength
        {
            get { return caplength; }
            set { caplength = value; }
        }
        public string Brand
        {
            get;
            set;
        }
        public Refill1 R
        {
            get;
            set;
        }
        
        static void Main(string[] args)
        {
            PenContainmentgeterseter p1 = new PenContainmentgeterseter();
            p1.Caplength = 1;
            p1.Brand = "cello";
            Console.WriteLine(p1.Caplength+" "+p1.Brand);

            Refill1 r = new Refill1();
            r.Inkcolour = "Red";
            r.Length = 2;
            Console.WriteLine(r.Inkcolour+" "+r.Length);

            Nib1 n = new Nib1();
            n.MaterialType = "Plastic";
            n.Width = 10;
            Console.WriteLine(n.MaterialType+" "+n.Width);
            Console.ReadLine();

        }
    }
}
