using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyNewProject1.Containment
{
    class Department

    {
        int did;
        string name;
        public int Did
        {
            get { return did; }
            set { did = value; }
        }
        public string Name
        {
            get;
            set;
        }
    }
    class Employee
    {
        int eid;
        string name;
        Department dept;
        public int Eid
        {
            get;
            set;
        }
        public string Name
        {
            get { return name; }
            set { name = value; }
        }
        public Department Dept
        {
            get { return dept; }
            set { dept = value; }
        }
        static void Main(string[] args)
        {
            /* Department d = new Department();
             d.Did = 101;
             d.Name = "Sales";

             Employee e = new Employee();
             e.Eid = 1;
             e.Name = "Pranjal";
             e.Dept = d;
             Console.WriteLine(d.Did+" "+d.Name+" "+e.Eid+" "+e.Name);*/

            Employee e = new Employee();
            e.Eid = 1;
            e.Name = "Rajashri";
            e.Dept = new Department();
            e.Dept.Did = 101;
            e.Dept.Name = "hR";
            Console.WriteLine(e.Eid+" "+e.Name+" "+e.Dept.Did+" "+e.Dept.Name);


            Console.ReadLine();

        }
    }
}
