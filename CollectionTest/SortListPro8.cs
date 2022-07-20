using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyNewProject1.CollectionTest
{
    class SortListPro8
    {
        //8.WAP to sort the elements of List that contains String objects.Print List.
        static void Main(string[] args)
        {
            List<string> lst = new List<string>();
            lst.Add("Java");
            lst.Add("Csharp");
            lst.Add("Dot Net");
            lst.Add("Programming");
            lst.Add("C");
            lst.Add("Angular");
            lst.Sort();
            foreach(string s in lst)
                Console.WriteLine(s);
            Console.ReadLine();
        }
    }
}
