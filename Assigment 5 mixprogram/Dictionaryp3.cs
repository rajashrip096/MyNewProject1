using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyNewProject1.Assigment_5_mixprogram
{
    class SocietyMember: IComparable<SocietyMember>
    {
        int memberid;
      
        string name;

        public int Memberid { get => memberid; set => memberid = value; }
        
        public string Name { get => name; set => name = value; }

        public SocietyMember(int memberid, string wing_flatno, string name)
        {
            this.Memberid = memberid;
           
            this.Name = name;
        }

        public override bool Equals(object obj)
        {
            return obj is SocietyMember member &&
                   Memberid == member.Memberid &&
                   Name == member.Name;
        }

        /* public override int GetHashCode()
         {
             int hashCode = 1343516035;
             hashCode = hashCode * -1521134295 + EqualityComparer<string>.Default.GetHashCode(memberid);
             hashCode = hashCode * -1521134295 + EqualityComparer<string>.Default.GetHashCode(wing_flatno);
             hashCode = hashCode * -1521134295 + EqualityComparer<string>.Default.GetHashCode(name);
             return hashCode;
         }*/
        public int CompareTo(SocietyMember other)
        {
            return this.Name.CompareTo(other.Name);
        }
        public override string ToString()
        {
            return "Memberid : " + Memberid + " name :" + Name;
        }
    }
    class Wing_FlatNo:IComparable<Wing_FlatNo>
    {
        string wing_flatno;

        public Wing_FlatNo(string wing_flatno)
        {
            this.Wing_flatno = wing_flatno;
        }

        public string Wing_flatno { get => wing_flatno; set => wing_flatno = value; }
        public int CompareTo(Wing_FlatNo other)
        {
            return this.Wing_flatno.CompareTo(other.Wing_flatno);
        }
        public override string ToString()
        {
            return " Wing_FlatNo :" + Wing_flatno;
        }
    }
    class Dictionaryp3
    {
        //3.Assume that there is already  list of members of Society Member{memberid,Wing_flatNo,name}.
        //Write a program which creates Dictionary where key is Wing_FlatNo and value is List
        //of all  names of family members 
        static void Main(string[] args)
        {
            List<SocietyMember> ll = new List<SocietyMember>();
            ll.Add(new SocietyMember(1, "A 11", "Raj"));
            ll.Add(new SocietyMember(2, "B 22", "Siya"));
            ll.Add(new SocietyMember(3, "C 12", "Diya"));
            ll.Add(new SocietyMember(4, "D 22", "Navin"));
            

            Dictionary<Wing_FlatNo,int> dd = new Dictionary<Wing_FlatNo,int>();


        }
    }
}
