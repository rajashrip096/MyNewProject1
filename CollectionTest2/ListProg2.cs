using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyNewProject1.CollectionTest2
{
    //2.WAP to create a class Employee with (name, designation ,salary).
    //Now create and add Employee objects elements to List. Print List.
    class Employee
    {
        string name;
        string designation;
        int salary;

        public Employee(string name, string designation, int salary)
        {
            this.Name = name;
            this.Designation = designation;
            this.Salary = salary;
        }

        public string Name { get => name; set => name = value; }
        public string Designation { get => designation; set => designation = value; }
        public int Salary { get => salary; set => salary = value; }

        public int CompareTo(Employee other)
        {
            return this.name.CompareTo(other.name);
        }
        public override string ToString()
        {
            return "Name : " + name + " Designation :" + designation + " Salary :" + salary;
        }
    }
    class ListProg2
    {
        static void Main(string[] args)
        {
            List<Employee> l1 = new List<Employee>();
            l1.Add(new Employee( "Raj","HR",723676));
            l1.Add(new Employee("Priya", "Developer", 988765));
            l1.Add(new Employee("Nisha", "Manager", 2454666));
            l1.Add(new Employee("Amit", "CEO", 8654545));
            l1.Add(new Employee("Bala", "Executive", 53656));
            l1.Add(new Employee("Ojas", "HR", 723676));

            foreach(Employee e1 in l1)
                Console.WriteLine(e1);
            Console.ReadLine();
        }
       
    }
}
