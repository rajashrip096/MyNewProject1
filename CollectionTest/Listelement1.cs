using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyNewProject1.CollectionTest
{
    class Listelement1
    {
        //1.	WAP add elements to List<String>,insert at specifies=d position
        //,update and delete a element.
        static void Main(string[] args)
        {
            List<string> ll = new List<string>();
            ll.Add("Rajashri");
            ll.Add("Raj");
            ll.Add("Nilesh");

            ll.Remove("Raj");
            foreach(string d in ll)
                Console.WriteLine(d);
            Console.ReadLine();
        }
    }
}
