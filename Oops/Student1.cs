using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyNewProject1.Oops
{
    
    class Student1
    {
        public int id;
        public string name;
        public int marks;//instance variable

        static void Main(string[] args)
        {
            Student1 nikhil = new Student1();
            nikhil.id = 45;
            nikhil.name = "Nikhil";
            nikhil.marks = 78;

            Student1 stud = new Student1();
            stud.id = 100;
            stud.name = "Yash";
            stud.marks = 88;

            Console.WriteLine(nikhil.id + " " + nikhil.name + " " + nikhil.marks);
            Console.WriteLine(stud.id+" "+stud.name+" "+stud.marks);
            Console.ReadLine();
        }
    }
}
