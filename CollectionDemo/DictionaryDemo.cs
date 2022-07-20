using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyNewProject1.CollectionDemo
{
    class DictionaryDemo
    {
        static void Main(string[] args)
        {
            List<Emp> ll = new List<Emp>();
            ll.Add(new Emp("Raj", 8));
            ll.Add(new Emp("neha", 9));

            Dictionary<string, int> dd = new Dictionary<string, int>();
            dd.Add("Nilesh", 90);
            dd.Add("Rajesh", 90);
            dd.Add("Maya", 92);
            Console.WriteLine(dd["Rajesh"]);
            dd["Rajesh"] = 94;

            dd.Remove("Nilesh");
            //Console.WriteLine(dd["Nilesh"]);
            dd.Clear();
            dd.ContainsKey("Jyoti");
            dd.ContainsValue(90);

            Dictionary<Emp, int> d2 = new Dictionary<Emp, int>();
            d2.Add(new Emp("Omkar", 9), 98889787);
            d2.Add(new Emp("Omkar", 9), 98889787);

            foreach(KeyValuePair<Emp,int> kp in d2)
                Console.WriteLine(kp.Key +"=>"+kp.Value);
            Console.ReadLine();
        }
    }
}
