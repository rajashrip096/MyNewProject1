using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyNewProject1.CollectionTest2
{
    class Queuep3
    {
        //3.WAP to create a Queue with some colors (String) using generics.
        static void Main(string[] args)
        {
            Queue<string> q1 = new Queue<string>();
            q1.Enqueue("Red");
            q1.Enqueue("Blue");
            q1.Enqueue("Pink");
            q1.Enqueue("Yellow");
            q1.Enqueue("Black");
            q1.Enqueue("Green");
            q1.Enqueue("Red");

            foreach(string ss in q1)
                Console.WriteLine(ss);
            Console.ReadLine();

        }
    }
}
