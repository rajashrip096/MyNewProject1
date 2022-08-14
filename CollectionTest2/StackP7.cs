using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyNewProject1.CollectionTest2
{
    class StackP7
    {
        //7.Make use of such collection that stores moviename such that last entered movie is first
        // deleted and accordingly previous one
        static void Main(string[] args)
        {
            Stack<string> ss = new Stack<string>();
            ss.Push("Hum");
            ss.Push("Houseful");
            ss.Push("KGF");
            ss.Push("RRR");
            ss.Push("Dhangal");
            ss.Pop();

            foreach(string s in ss)
            {
                Console.WriteLine(s);
            }
            Console.ReadLine();
        }

    }
}
