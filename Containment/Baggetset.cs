using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyNewProject1.Containment
{
    class Nibp
    {
        string type;
        public string Type
        {
            get; set;
        }
    }
    class Pen1
    {
        string pname;
        string pcolour;
        Nibp n;
        public string Pname
        {
            get;
            set;
        }
        public string Pcolour
        {
            get; set;
        }
        public Nibp N
            {
            get;
            set;
            }
    }
    class Baggetset
    {
        string colour;
        string name;
        int price;
        Pen1 p;
       //Nibp n;
        public string Colour
        {
            get;
            set;
        }
        public string Name
        {
            get;set;
        }
        public int Price
        {
            get;
            set;
        }
        public Pen1 P
        {
            get;
            set;
        }
        static void Main(string[] args)
        {
            Baggetset b = new Baggetset();
            b.Colour = "Red";
            b.Name = "Adidas";
            b.Price = 5635;
            b.p = new Pen1();
            b.p.Pname = "Cello";
            b.p.Pcolour = "Blue";
            b.p.N = new Nibp();
            b.p.N.Type = "metal";

            Console.WriteLine(b.Colour+"    "+b.Name+"    "+b.Price+"   "+b.p.Pname+"   "+b.p.Pcolour+"   "+b.p.N.Type);
            Console.ReadLine();




        }
    }
}
