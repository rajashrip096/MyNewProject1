using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyNewProject1.Oops
{
    //write the code a student class ,student has id ,name,three subj.marks.
    //1.create 1st method to accept details of student.
    // 2.create 2nd method to calculate percentage of student 
    //3.create 3rd method to display details of student & percentage
    
    class Student
    {
        public int id;
        public string name;
        public int m1, m2, m3;
        public double perc;

        public void AcceptDetail(int sid,string sname,int sub1,int sub2,int sub3)
        {
            id = sid;
            name = sname;
            m1 = sub1;
            m2 = sub2;
            m3 = sub3;
        }
        public void  Calculate()
        {
            perc = (m1 + m2 + m3) / 3;
            
        }
        public void Display()
        {
            Console.WriteLine("id \t name \t m1 \t m2 \t m3\t per");
            Console.WriteLine(id+"     "+name+"     "+m1+"  "+m2+"   "+m3+"  "+perc);
            Console.ReadLine();
        }
       
        static void Main(string[] args)
        {
            Student s1 = new Student();
            s1.AcceptDetail(101 , "Rajashri", 67, 78, 90);
            s1.Calculate();
            s1.Display();

        }
    }
}
