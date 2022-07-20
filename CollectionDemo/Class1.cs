using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyNewProject1.CollectionDemo
{
    class Class1
    {
        static void Main(string[] args)
        {
            List<int> lst = new List<int>();
            lst.Add(100);
            lst.Add(200);
            lst.Add(300);
            lst.Add(400);
           // lst.Add(500);
            //lst.Add(300);
           // lst.Add(300);
           // lst.Add(300);
           // lst.Remove(300);
           // lst[0] = 1000;
            Console.WriteLine(lst.Count);
            Console.WriteLine(lst.Capacity);
             for(int i=0;i<lst.Count;i++)
            {
                Console.WriteLine(lst[i]);
            }
            //Console.WriteLine("///////////////////////");
            //  foreach(int data in lst)
            //  Console.WriteLine(data);
            Console.WriteLine(lst.Contains(90));
            Console.WriteLine("indexOf"+lst.IndexOf(309));
            List<int> lst2 = new List<int>() { 111, 222, 333 };
            //lst2.AddRange(lst);
             lst2.InsertRange(1, lst);
            for (int i = 0; i < lst2.Count; i++)
            {
                Console.WriteLine(lst2[i]);
            }
            Console.ReadLine();

        }
    }
}
