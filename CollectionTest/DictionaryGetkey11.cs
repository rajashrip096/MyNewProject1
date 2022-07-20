using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyNewProject1.CollectionTest
{
    class DictionaryGetkey11
    {
        //11.WAP to get only the Keys from a Dictionary.
        static void Main(string[] args)
        {
            Dictionary<int, string> dd = new Dictionary<int, string>();
            dd.Add(1, "Ram");
            dd.Add(2, "Riya");
            dd.Add(3, "Sima");
            dd.Add(4, "Rahul");
            dd.Add(5, "Samir");
            dd.Add(6, "Maya");
            dd.Add(7, "Piyu");
           
            foreach (KeyValuePair<int, string> k in dd)
                Console.WriteLine(k.Key);
            Console.ReadLine();
            
        }
    }
}
