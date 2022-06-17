using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyNewProject1.Oops
{
    class Employee
    {
        int id;
        string name;
        int salary;
        public Employee(int eid, string ename, int esalary)
        {
            //initilization of instance variable
            id = eid;
            name = ename;
            salary = esalary;
        }

        void Display()
        {
            Console.WriteLine(id + " " + name + " " + salary);
        }
        static void Main(string[] args)
        {
            Employee e = new Employee(101, "Rajashri", 600800);
            e.Display();
            Console.ReadLine();
        }
    }
}
