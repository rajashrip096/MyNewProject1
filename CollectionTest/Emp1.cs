using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyNewProject1.CollectionTest
{
    class Emp1
    {
        int eno;
        string name;
        string deptname;

        public Emp1(int eno, string name, string deptname)
        {
            this.eno = eno;
            this.name = name;
            this.deptname = deptname;
        }
     
        public int CompareTo(Emp1 other)
        {
            return this.name.CompareTo(other.name);
        }
        public override string ToString()
        {
            return "Eno : " + Eno + " Name :" + Name + " Departmentname :" + Deptname;
        }

        public int Eno { get => eno; set => eno = value; }
        public string Name { get => name; set => name = value; }
        public string Deptname { get => deptname; set => deptname = value; }
    }
}
