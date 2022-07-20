using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyNewProject1.CollectionDemo
{
    class DictionaryD3
    {
        static void Main(string[] args)
        {
            Dictionary<string, int> dd = new Dictionary<string, int>();
            dd.Add("Nilesh", 90);
            dd.Add("dhiraj", 90);
            dd.Add("Shubham", 91);
            dd.Add("Raj", 92);
            ICollection<string> cc = dd.Keys;
            foreach(string k in cc)
                Console.WriteLine(k);
            foreach(KeyValuePair<string ,int> kv in dd)
                Console.WriteLine(kv.Key+"==> "+kv.Value);
            Console.ReadLine();
        }
    }
    class DictionD4
    {
        static void Main(string[] args)
        {
            Dictionary<string, string> dd = new Dictionary<string, string>();
            dd.Add("Nilesh", "Java");
            dd.Add("Dhiraj", "CSharp");
            dd.Add("Riya", "Java");

            dd.Add("Shubham", "CSharp");
            dd.Add("Raj", "Python");
            dd.Add("Nil", "Python");

            Dictionary<string, List<string>> d2 = new Dictionary<string, List<string>>();
            //"java"=>[Nilesh];
            //"CSharp=>[Dhiraj];

            foreach(KeyValuePair<string,string> kv in dd)
            {
                string sname = kv.Key;
                string coursename = kv.Value;
                if(d2.ContainsKey(coursename))
                {
                    List<string> l2 = d2[coursename];
                    l2.Add(sname);
                }
                else
                {
                    List<string> lst = new List<string>();
                    lst.Add(sname);
                    d2.Add(coursename, lst);
                }
            }
            foreach(KeyValuePair<string,List<string>> kv in d2)
            {
                string cnm = kv.Key;
                List<string> studlist =kv.Value;
                Console.WriteLine("{Coursename = "+cnm);
                foreach(string snm in studlist)
                    Console.Write(snm + " ");

                Console.WriteLine();
            }
            Console.ReadLine();
        }
    }
}
