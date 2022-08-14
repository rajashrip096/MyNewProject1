using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyNewProject1.CollectionTest2
{
    //8.WAP to create SortedList<Employee,string> where key is of Employee type
    //and value is departmentname(string) he works in. SortedList should maintain
    //data in descending order of salary.
    class SortedListDecendening8
    {
        static void Main(string[] args)
        {
            SortedList<Employee1, string> ss = new SortedList<Employee1, string>();
            ss.Add(new Employee1("Raj", "HR", 535677), "Sales");
            ss.Add(new Employee1("Amit", "Developer", 5345577), "Production");
            ss.Add(new Employee1("Yatin", "Executive", 35677), "Maintanance");
            ss.Add(new Employee1("Mukesh", "Ceo", 345677), "Quality");
            ss.Add(new Employee1("Gauri", "Manager", 987677), "Admin");
            ss.Add(new Employee1("Daya", "Leader", 1233677), "Store");

            foreach(KeyValuePair<Employee1,string> kv in ss)
                Console.WriteLine(kv.Key +" === "+kv.Value);
            Console.ReadLine();

        }
    }
    class Employee1:IComparable<Employee1>
    {
        string name;
        string designation;
        int salary;

        public Employee1(string name, string designation, int salary)
        {
            this.Name = name;
            this.Designation = designation;
            this.Salary = salary;
        }

        public string Name { get => name; set => name = value; }
        public string Designation { get => designation; set => designation = value; }
        public int Salary { get => salary; set => salary = value; }

        public int CompareTo(Employee1 other)
        {
            return this.name.CompareTo(other.name);
        }
        public override string ToString()
        {
            return "Name : " + name + " Designation :" + designation + " Salary :" + salary;
        }
    }
}
