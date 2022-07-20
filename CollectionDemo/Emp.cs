using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyNewProject1.CollectionDemo
{
    class Emp
    {
        string name;
        int experience;
        public Emp()
        {

        }
        public Emp(string name, int experience)
        {
            this.Name = name;
            this.experience=experience;
        }

        public string Name
        { 
            get => name;
            set => name = value; 
        }
        public int Experionece
        { 
            get => experience;
            set => this.experience = value;
        }
        public override string ToString()
        {
            return "Name :  "  + name + " Experinece :  " + experience; 
        }
        public override bool Equals(object obj)
        {
            return obj is Emp emp &&
                name == emp.name && experience == emp.experience;
        }

        static void Main(string[] args)
        {
            Emp e = new Emp("Rajesh", 9);
            // Emp e = new Emp("Rajesh", 9);
            Console.ReadLine();
        }
    }
}
