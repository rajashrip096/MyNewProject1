using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyNewProject1.CollectionTest2
{
    class ListProg1
    {
        //1.WAP to sort the elements of List that contains String objects. Print List.
        static void Main(string[] args)
        {
            List<string> l2 = new List<string>();
            l2.Add("Sales");
            l2.Add("HR");
            l2.Add("Executive");
            l2.Add("Developer");
            l2.Add("Java");
            l2.Add("C#");

            l2.Sort();
            foreach(string s1 in l2)
                Console.WriteLine(s1);
            Console.ReadLine();
        }
    }
}
