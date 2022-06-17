using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyNewProject1.Inheritance
{
    class Person
    {
        public string name = "Rajesh";
    }
    class Employee : Person
    {
        public int id = 101;
        public string deptname = "Sale";
    }
    class Manager : Employee
    {
        public int salary = 9080908;

        public void show()
        {
            Console.WriteLine(name + " " + id + " " + deptname + " " + salary);
            Console.ReadLine();
        }
    }
    class MultilevelInheritance
    {
        static void Main(string[] args)
        {
            Manager m = new Manager();
            m.show();
        }
    }
}
