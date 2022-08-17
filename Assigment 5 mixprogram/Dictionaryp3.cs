using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyNewProject1.Assigment_5_mixprogram
{
    class SocietyMember
    {
        int memberid;
        string wing_flat_no;
        string name;

        public SocietyMember(int memberid, string wing_flat_no, string name)
        {
            this.Memberid = memberid;
            this.Wing_flat_no = wing_flat_no;
            this.Name = name;
        }
        public int Memberid 
        { 
            get { return memberid; }
            set { memberid = value; } 
        }
        public string Wing_flat_no 
        {
            get { return wing_flat_no; }
            set { wing_flat_no = value; } 
        }
        public string Name 
        {
            get { return name; }
            set { name = value; } 
        }
        public override string ToString()
        {
            return "memberid :" + memberid + "wing_flat_no :" + wing_flat_no + "name :" + name;
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
            ll.Add(new SocietyMember(1, "A-201 ", "Rajashri"));
            ll.Add(new SocietyMember(2, "B-405", "Siya"));
            ll.Add(new SocietyMember(3, "A-201", "Diya"));
            ll.Add(new SocietyMember(4, "A-201", "Navin"));
            ll.Add(new SocietyMember(5, "b-201", "Raj"));
            ll.Add(new SocietyMember(6, "c-201", "Esha"));
            
            Dictionary<string,List<SocietyMember>> dd = new Dictionary<string,List<SocietyMember>>();

            foreach(SocietyMember m in ll)
            {
                if(dd.ContainsKey(m.Wing_flat_no))
                {
                    List<SocietyMember> l = new List<SocietyMember>();
                    l.Add(m);
                }
                else
                {
                    List<SocietyMember> l1 = new List<SocietyMember>();
                    l1.Add(m);
                    dd.Add(m.Wing_flat_no, l1);
                }
            }
            foreach(KeyValuePair<string,List<SocietyMember>> kv in dd)
            {
                Console.WriteLine("Flat No :"+kv.Key);     
          
                foreach(SocietyMember m in kv.Value )
                Console.WriteLine(m);
            }
            Console.ReadLine();
        }
    }
}
