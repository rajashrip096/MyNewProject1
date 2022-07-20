using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyNewProject1.AbstrctandInterface
{
    abstract class Person
    {
        public abstract void show(); 
    }
     abstract class Employee : Person
    {
        public override void show()
        {
            Console.WriteLine("Employee is working");
        }
    }
    class Manager : Employee
    {
         public override void show()
         {
             Console.WriteLine("Manager is working");
         }
    }
    
    class AbstractDemo2
    {
        static void Main(string[] args)
        {
            //Person p = new Employee();
          // p.show();
            Employee e = new Manager();
            e.show();
            Console.ReadLine();
        }
    }
}
