using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyNewProject1.CollectionTest
{
    //10.	WAP to add elements to a Dictionary and print content of it.
    //Use int as Key and String as Value.
    //Also iterate over dictionary and print key value pair.
    class DictionaryKeyValuep10
    {
        static void Main(string[] args)
        {
            Dictionary<int, string> d = new Dictionary<int, string>();
            d.Add(1, "Raj");
            d.Add(2, "Sima");
            d.Add(3, "Rahul");
            d.Add(4, "Shubham");
            d.Add(5, "Harsha");
            foreach (KeyValuePair<int,string> kv in d)
                Console.WriteLine(kv.Key+"==>"+kv.Value);
            Console.ReadLine();
        }
    }
}
