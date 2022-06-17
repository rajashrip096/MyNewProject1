using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyNewProject1.Containment
{
    class OrderDateshipment
    {
        string orderdate;
        public string Orderdate
        {
            get;
            set;
        }
    }
    class Ordershipment
    {
        int oid;
        string name;
        string city;
        OrderDateshipment od;
        public int Oid
        {
            get { return oid; }
            set { oid = value; }
        }
        public string Name
        {
            get;
            set;
        }
        public string City
        {
            get;
            set;
        }
        public OrderDateshipment Od
        {
            get;
            set;
        }
    }
    class Shipmentgetset
    {
        int sid;
       Ordershipment o;
       
        public int Sid
        {
            get{ return sid; }
            set { sid = value; }
        }
        Ordershipment O
        {
            get;
            set;

        }

        
        static void Main(string[] args)
        {
            Shipmentgetset s = new Shipmentgetset();
            s.Sid = 101;
            Console.WriteLine(s.Sid);
            //Console.ReadLine();

            Ordershipment o = new Ordershipment();
            o.Oid = 1;
            o.Name = "Rajashri";
            o.City = "pune";
            Console.WriteLine(o.Oid+"  "+o.Name+"  "+o.City);
            //Console.ReadLine();

            OrderDateshipment od = new OrderDateshipment();
            od.Orderdate ="6/14/2022";
            Console.WriteLine(od.Orderdate);
            Console.ReadLine();



        }
    }
}
