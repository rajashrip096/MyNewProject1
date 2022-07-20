using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyNewProject1.CollectionDemo
{
    class HashSetDemo
    {
        static void Main(string[] args)
        {
            HashSet<string> hs1 = new HashSet<string>() { "Om", "Raj", "Ram", "Siya" };
            HashSet<string> hs2 = new HashSet<string>() { "Omkar", "Raja", "Ram", "Siya" };

            //HashSet<string> h3 = hs1.Intersect(hs2).ToHashSet();

            //hs1.UnionWith(hs2);

            bool b1 = hs1.IsSubsetOf(hs1);
            bool b2 = hs2.IsSupersetOf(hs1);

            foreach(string d in hs1)
                Console.WriteLine(d+" ");

            Console.WriteLine();
            foreach(string d in hs2)
                Console.WriteLine(d+" ");
            Console.WriteLine();

           /* foreach(string d in h3)
                Console.WriteLine(d+" ");
            hs1.IntersectWith(hs2);*/

            Console.ReadLine();

        }
    }
}
