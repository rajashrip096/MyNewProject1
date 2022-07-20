using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyNewProject1.CollectionTest
{
    class ListC2
    {
        static void Main(string[] args)
        {
            //2.WAP to create a new List, add some colors(string)
            //and print the collection.

            List<string> ll =new List<string>();

            ll.Add("Red");
            ll.Add("Blue");
            ll.Add("Yellow");
            ll.Add("Pink");

            foreach(string d in ll)
                Console.WriteLine(d);
            Console.ReadLine();
        }
    }
}
