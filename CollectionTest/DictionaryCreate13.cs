using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyNewProject1.CollectionTest
{
    class DictionaryCreate13
    {
        //13.WAP to create a  Dictionary  using Custom class as key
        //and any other object as value
        static void Main(string[] args)
        {
            Dictionary<string, int> dd = new Dictionary<string, int>();
            dd.Add("Nilesh", 11);
            dd.Add("Raj", 12);
            dd.Add("Maya", 13);
            dd.Add("Riya", 14);
            dd.Add("Radha", 15);
            //dd.Add("Riya", 16);
            foreach(KeyValuePair<string,int> kv in dd)
                Console.WriteLine(kv.Key + "==> "+kv.Value);
            Console.ReadLine();
        }
    }
}
