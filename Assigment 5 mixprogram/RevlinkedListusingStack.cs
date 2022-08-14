using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyNewProject1.Assigment_5_mixprogram
{
    class RevlinkedListusingStack
    {
        //6.WAP to  Reverse a linked list using Stack. 
        static void Main(string[] args)
        {
            LinkedList<int> ll = new LinkedList<int>();
            ll.AddFirst(100);
            ll.AddFirst(200);
            ll.AddFirst(300);
            ll.AddFirst(400);
            ll.AddFirst(500);
            ll.AddFirst(600);
            ll.AddFirst(700);

            foreach(int d in ll)
                Console.WriteLine(d);
            Console.WriteLine("**********************************************************");
            Stack<int> ss = new Stack<int>(ll);

            foreach(int d in ss)
                Console.WriteLine(d);


            Console.ReadLine();
        }
    }
}
