using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyNewProject1.CollectionTest
{
    class LinkListPro16
    {
        // 16.WAP to create a LinkedList<Emp> and search for Emp object
        // whose eno=10 and delete all the records whose dept is same as  eno 10.
        // Emp(int eno, String name string deptnmae)
        static void Main(string[] args)
        {
            LinkedList<Emp1> ll = new LinkedList<Emp1>();
            ll.AddLast(new Emp1(1, "AA", "IT"));
            ll.AddLast(new Emp1(3, "BB", "Testing"));
            ll.AddLast(new Emp1(4, "CC", "HR"));
            ll.AddLast(new Emp1(7, "DD", "IT"));
            ll.AddLast(new Emp1(10, "EE", "IT"));
            ll.AddLast(new Emp1(11, "FF", "HR"));
            ll.AddLast(new Emp1(12, "GG", "Testing"));
            string dname = "";
            foreach(Emp1 e in ll)
            {
                if(e.Eno==10)
                {
                    dname = e.Deptname;
                    break;
                }
            }
            foreach(Emp1 e in ll)
            {
                if(e.Deptname==dname)
                {
                    Console.WriteLine(e);
                }
            }
            Console.ReadLine();
        }
    }
}
