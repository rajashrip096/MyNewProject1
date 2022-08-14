using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyNewProject1.CollectionTest2
{
    class SortedListp5
    {
        //5.WAP to create SortedList where key is of Integer type and
        //value string and print all key-value pairs.
        static void Main(string[] args)
        {
            SortedList<int, string> ss = new SortedList<int, string>();
            ss.Add(1, "Radha");
            ss.Add(24, "Shalu");
            ss.Add(5, "Amit");
            ss.Add(11, "Om");
            ss.Add(31, "Priya");
            ss.Add(561, "Harsha");
            ss.Add(12, "Yatin");
            ss.Add(9, "Sarvesh");

            foreach(KeyValuePair<int,string> kv in ss)
                Console.WriteLine(kv.Key+" ====>"+kv.Value);
            Console.ReadLine();

        }
    }
}
