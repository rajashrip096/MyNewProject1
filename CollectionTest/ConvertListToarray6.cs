using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyNewProject1.CollectionTest
{
    class ConvertListToarray6
    {
        //6.WAP to convert List to array.
        static void Main(string[] args)
        {
            List<int> lst = new List<int>();
            lst.Add(100);
            lst.Add(200);
            lst.Add(300);
            lst.Add(400);
            lst.Add(500);
            lst.Add(600);
            
            //Array creation
            int[] a =lst.ToArray();
            Console.WriteLine("Element of Array is :");
            foreach(int i in a)
                Console.WriteLine(i);
            Console.ReadLine();


        }
    }
}
