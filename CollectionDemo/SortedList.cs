using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyNewProject1.CollectionDemo
{
    class SortedList
    {
        static void Main(string[] args)
        {
            SortedList<Empp, string> ss = new SortedList<Empp, string>();
            ss.Add(new Empp(1, "Riya", "IT"), "MR A");
            ss.Add(new Empp(2, "Maya", "Computer"), "MR B");
            ss.Add(new Empp(2, "Harsh", "Mechanical"), "MR c");
            ss.Add(new Empp(2, "Saya", "IT"), "MR D");
            ss.Add(new Empp(2, "Om", "Computer"), "MR E");
            ss.Add(new Empp(2, "Mehul", "IT"), "MR R");
            ss.Add(new Empp(2, "Raj", "IT"), "MR S");
            

           // Console.WriteLine("Deepa".CompareTo("Pratiksha"));
           // Console.WriteLine("Pratiksha".CompareTo("Deepa"));

            foreach (KeyValuePair<Empp,string> kv in ss)
                Console.WriteLine(kv.Key+"====>"+kv.Value);
            Console.ReadLine();
        }
    }
    class Demosortlist2
    {
        static void Main(string[] args)
        {
            //strore data in sorted order according theb key
            //Bst-Binary
            SortedList<string, int> ss = new SortedList<string, int>();
            ss.Add("Devesh", 90);
            ss.Add("Amey", 90);
            ss.Add("Chirag", 90);
            ss.Add("Siya", 90);
            ss.Add("Saif", 90);
            ss.Add("Tanish", 90);
            ss.Add("Harsh", 90);
            //ss.Add("Devesh", 93);  //error:System.aRgumentException;duplicate key

            ss["Devesh"] = 99;
            Console.WriteLine(ss.ContainsKey("Riya"));
            ss.Remove("Amey");
            foreach(KeyValuePair<string,int> kv in ss)
            {
                Console.WriteLine(kv.Key+"===>"+kv.Value);
            }
            Console.ReadLine();
        }
    }
}
