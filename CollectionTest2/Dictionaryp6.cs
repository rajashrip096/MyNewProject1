using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyNewProject1.CollectionTest2
{
    class Dictionaryp6
    {
        //6.WAP to create Dictionary where key is of string type and
        //value of float type and print all key-value pairs.
        static void Main(string[] args)
        {
            Dictionary<string, float> dd = new Dictionary<string, float>();
            dd.Add("Raj", 1.2f);
            dd.Add("Shivam", 9.2f);
            dd.Add("Gaurav", 6.2f);
            dd.Add("Maya", 51.2f);
            dd.Add("Sapana", 11.2f);
            dd.Add("Priya", 55.2f);
            dd.Add("Tosha", 8.2f);

            foreach(KeyValuePair<string,float> kv in dd)
                Console.WriteLine(kv.Key+"====."+kv.Value);
            Console.ReadLine();

        }
    }
}
