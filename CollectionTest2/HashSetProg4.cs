using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyNewProject1.CollectionTest2
{
    //4.WAP to add user defined objects of type Employee in a HashSet employee object.
    //Make sure if I create 2 different objects with same data the other
    //one should not be added as hashset stores unique objects
    class HashSetProg4
    {
        static void Main(string[] args)
        {
            HashSet<Emp> hs = new HashSet<Emp>();
            hs.Add(new Emp(1, "Raj"));
            hs.Add(new Emp(2, "Priya"));
            hs.Add(new Emp(3, "Amit"));
            hs.Add(new Emp(1, "Raj"));
            hs.Add(new Emp(3, "Amit"));

            foreach (Emp e2 in hs)
                Console.WriteLine(e2);
            Console.ReadLine();
        }
    }
    class Emp
    {
        int eid;
        string name;

        public Emp(int eid, string name)
        {
            this.Eid = eid;
            this.Name = name;
        }

        public int Eid { get => eid; set => eid = value; }
        public string Name { get => name; set => name = value; }

        public override bool Equals(object obj)
        {
            return obj is Emp emp &&
                   eid == emp.eid &&
                   name == emp.name;
        }
       /* public int CompareTo(Emp other)
        {
            return this.name.CompareTo(other.name);
        }*/
        public override string ToString()
        {
            return "Eid : "  + eid + "  Name : " + name;
        }

        public override int GetHashCode()
        {
            int hashCode = -758854069;
            hashCode = hashCode * -1521134295 + eid.GetHashCode();
            hashCode = hashCode * -1521134295 + EqualityComparer<string>.Default.GetHashCode(name);
            return hashCode;
        }
    }
}
