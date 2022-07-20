using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyNewProject1.CollectionTest
{
    class StudList5
    {
        //5. WAP to create List of Students and iterate over it.
        static void Main(string[] args)
        {
            List<string> ll = new List<string>();
            ll.Add("Radha");
            ll.Add("Maya");
            ll.Add("Raj");
            ll.Add("Radha");
            ll.Add("Riya");
            foreach(string s in ll)
                Console.WriteLine(s);
            Console.ReadLine();
        }
    }
}
