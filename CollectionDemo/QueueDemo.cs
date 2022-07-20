using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyNewProject1.CollectionDemo
{
    class QueueDemo
    {
        static void Main(string[] args)
        {
            //FIFO => First in Fist Out
            Queue<int> q = new Queue<int>();
            q.Enqueue(100);
            q.Enqueue(200);
            q.Enqueue(300);
            q.Enqueue(400);

            // int remove = q.Dequeue();
            // q.Clear();
            ///q.CopytTo();
            foreach(int d in q)
                Console.WriteLine(d);
            Console.ReadLine();
        }
    }
}
