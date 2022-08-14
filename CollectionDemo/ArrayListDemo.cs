using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections;

namespace MyNewProject1.CollectionDemo
{
    class ArrayListDemo
    {
        static void Main(string[] args)
        {
            ArrayList al = new ArrayList();
            al.Add("Mumbai");
            al.Add(10);
            al.Add("Solapur");
            al.Add("Pune");
            al.Add(4.3);
            al[1] = "Jalgaon";
            al.Remove("Pune");

            foreach(var v in al)
                Console.WriteLine(v);
            Console.ReadLine();


        }
    }
}
