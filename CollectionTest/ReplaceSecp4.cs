using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyNewProject1.CollectionTest
{
    class ReplaceSecp4
    {
       // 4.WAP to replace the second element of an List with the specified element
        static void Main(string[] args)
        {
            List<int> ll = new List<int>();
            ll.Add(1);
            ll.Add(2); 
            ll.Add(3);
            ll.Add(4);
            ll.Add(5);
            ll.Add(6);
            ll.Remove(2);
            foreach(int i in ll)
                Console.WriteLine(i);
            Console.ReadLine();


        }
    }
}
