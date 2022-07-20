using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyNewProject1.CollectionTest
{
    class ListReverseOrder7
    {
        //7.WAP to print list in reverse order .
        static void Main(string[] args)
        {
            List<int> lst = new List<int>();
            for(int i=1;i<=5;i++)
            {
                lst.Add(i);
            }
            foreach(int i in lst)
                Console.WriteLine(i);
            Console.ReadLine();

            Console.WriteLine("After reverse order :");
            lst.Reverse();
            foreach(int d in lst)
                Console.WriteLine(d);
            Console.ReadLine();
        }
    }
}
