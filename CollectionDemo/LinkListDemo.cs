using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyNewProject1.CollectionDemo
{
    class LinkListDemo
    {
        static void Main(string[] args)
        {
            LinkedList<int> ll = new LinkedList<int>();
            ll.AddFirst(100);
            ll.AddFirst(200);
            ll.AddFirst(300);
            ll.AddLast(500);
            LinkedListNode<int> nn = ll.Find(200);
            ll.AddBefore(nn,1000);
            ll.AddAfter(nn, 3000);
            //ll.Clear();
            Console.WriteLine(ll.Count);
            Console.WriteLine(ll.Contains(200));//element present in list i.e True either false

            int x = ll.First();
            int last = ll.Last();

            ll.Remove(90);
            foreach(int d in ll)
                Console.WriteLine(d);
            Console.ReadLine();
        }
    }
}
