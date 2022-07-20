using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyNewProject1.CollectionDemo
{
    class Empp:IComparable<Empp>
    {
        int eno;
        string name;
        string deptname;

        public Empp(int eno, string name, string deptname)
        {
            this.Eno = eno;
            this.Name = name;
            this.Deptname = deptname;
        }
        public int CompareTo(Empp other)
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
