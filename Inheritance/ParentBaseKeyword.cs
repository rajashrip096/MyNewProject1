using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyNewProject1.Inheritance
{
    class Student
    {
        public int marks = 80;
        public void get(string name)
        {
            Console.WriteLine("Student "+name);
        }
    }
    class Teacher : Student
    {
        public int marks = 90;
        public void show()
        {
            Console.WriteLine(marks+" "+base.marks);//Using base keyword
        }
        public void get()
        {
            base.get("Rajashri");
            Console.WriteLine("Teacher");

        }
    }
    class ParentBaseKeyword
    {
        static void Main(string[] args)
        {
            Teacher t = new Teacher();
            t.show();
            t.get();
            Console.ReadLine();
        }
    }
}
