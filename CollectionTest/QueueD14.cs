using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyNewProject1.CollectionTest
{
    class QueueD14
    {
        //14.WAP to create a Queue to add 5 objects and also
        //remove first two and iterate over it. 
        static void Main(string[] args)
        {
            //First in First Out
            Queue<int> q = new Queue<int>();
            q.Enqueue(100);
            q.Enqueue(200);
            q.Enqueue(300);
            q.Enqueue(400);
            q.Enqueue(500);
            int remove = q.Dequeue();
            int Remove = q.Dequeue();
            foreach(int i in q)
                Console.WriteLine(i);
            Console.ReadLine();
        }
    }
}
