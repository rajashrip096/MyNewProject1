using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyNewProject1.LINQDemo
{
    class Employee
    {
        int id;
        string name;
        int salary;
        string city;

        public int Id { get => id; set => id = value; }
        public string Name { get => name; set => name = value; }
        public int Salary { get => salary; set => salary = value; }
        public string City { get => city; set => city = value; }

        public override string ToString()
        {
            return $"{Id}->{Name}->{Salary}->{City}";
        }
    }
    class AssignmentEmpLinqtoObject
    {
        static void Main(string[] args)
        {
            List<Employee> emp = new List<Employee>()
            {
                new Employee{Id=1,Name="Sam",Salary=20000,City="Pune"},
                new Employee{Id=2,Name="Ram",Salary=25000,City="Pune"},
                new Employee{Id=3,Name="Siya",Salary=10000,City="Mumbai"},
                new Employee{Id=4,Name="Diya",Salary=25000,City="Banglore"},
                new Employee{Id=5,Name="Navin",Salary=30000,City="Nashik"},
                new Employee{Id=6,Name="Amit",Salary=35000,City="Solapur"},
                new Employee{Id=7,Name="Radha",Salary=40000,City="Pune"},
                new Employee{Id=8,Name="Maya",Salary=45000,City="Mumbai"},
                new Employee{Id=9,Name="Radha",Salary=50000,City="Nashik"},
                new Employee{Id=10,Name="Radha",Salary=70000,City=" Navi Mumbai"},

            };
            //display all employees
            var result = from e in emp
                         select e;
            //Lambda 
            var res6 =emp.ToList();

            //display employee with asending order by name
            var result1 = from e in emp
                          orderby e.Name
                          select e;
            //Lambda
            var res = emp.OrderBy(e => e.Name).ToList();

            //. display employee whose salary is > 25000
            var result2 = from e in emp
                           where e.Salary > 25000
                           select e;
            //Lambda
            var res1 = emp.Where(e => e.Salary > 25000).ToList();

            //display employee whos from 'Pune' City
            var result3 = from e in emp
                          where e.City=="Pune"
                          select e;
            //Lambda
            var res2 = emp.Where(e => e.City == "Pune").ToList();

            //display employee with desending order by salary
            var result4 = from e in emp
                         orderby e.Salary descending
                          select e;

            var res3 = emp.OrderBy(e => e.Salary).ToList();

            //display employee whose name start with 'P'
            var result5 = from e in emp
                          where e.City.StartsWith("P")
                          select e;
            //Lambda
            var res4 = emp.Where(e => e.City.StartsWith("P")).ToList();

            // display employee whose salary is > 25000 & emp is from 'Mumbai' city
            var result6 = from e in emp
                          where (e.Salary > 25000 ) && (e.City==("Mumbai"))
                          select e;
            //Lambda
            var res5 = emp.Where(e => e.Salary > 25000 && e.City ==("Mumbai")).ToList();

            foreach (Employee item in res)
            {
                Console.WriteLine(item);
            }
            Console.ReadLine();

        }
    }
}
