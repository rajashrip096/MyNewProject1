using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyNewProject1.CollectionDemo
{
    class Stud:IComparable<Stud>
    {
        string name;
        int mob;
        int id;

        public Stud(string name, int mob, int id)
        {
            this.Name = name;
            this.Mob = mob;
            this.Id = id;
          
        }

        public string Name { get => name; set => name = value; }
        public int Mob { get => mob; set => mob = value; }
        public int Id { get => id; set => id = value; }

        public int CompareTo(Stud other)
        {
            return this.name.CompareTo(other.name);
        }

        public override string ToString()
        {
            return "Name :  " + name + " Mob : " + mob + " Id : " +id;
        }
        public override bool Equals(object obj)
        {
            return obj is Stud stud &&
                name == stud.name && mob == stud.mob && id==stud.id;
        }

    }
    class SortedListUsingStudobj
    {
        static void Main(string[] args)
        {
            SortedList<Stud, string> ss = new SortedList<Stud, string>();
            ss.Add(new Stud("Raj", 283893290, 88), "java");
            ss.Add(new Stud("Gaurav", 283890000, 85), "java");
            ss.Add(new Stud("Radha", 2812390, 78), "java");
            ss.Add(new Stud("Trisha", 287849320, 98), "java");
            ss.Add(new Stud("Piya", 28465290, 56), "java");
            ss.Add(new Stud("Maya", 283450, 48), "java");
            ss.Add(new Stud("Diya", 28389790, 68), "java");

            foreach(KeyValuePair<Stud,string> kv in ss)
                Console.WriteLine(kv.Key+"===."+kv.Value);
            Console.ReadLine();

        }
    }
}
