using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyNewProject1.Oops
{
    /*class Department
    {
        int did;
        string dname;
        public int Did
        {
            get;
            set;
        }
        public string Dname
        {
            get;
            set;
        }
    }*/
    class Employee1
    {
        int eid;
        string name;
        double salary;

        public int Eid
        {
            get;
            set;
        }
        public string Name
        {
            get;
            set;
        }
        public double Salary
        {
            get { return salary; }
            set { salary = value; }
        }
        static void Main(string[] args)
        {
           /*Department d = new Department();
            d.Did = 101;
            d.Dname = "Rajashri";*/

            Employee1 e = new Employee1();
            e.eid = 1;
            e.name = "Amol";
            e.salary = 6276273;
            Console.WriteLine(e.eid+" "+e.name+" "+e.salary);
            //Console.WriteLine(e.eid+" "+e.name+" "+e.salary+" " +d.Did+ " "+d.Dname);
            Console.ReadLine();
        }
       
    }
}
