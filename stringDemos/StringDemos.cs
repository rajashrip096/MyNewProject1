using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyNewProject1.stringDemos
{
    class StringCreation
    {
        static void Main(string[] args)
        {
            string s = "Hello"; //using Keyword
            string str = "Hello"; //using Literal
           // string st = new string('Hello');//using new
            
           // Console.WriteLine(st == s);
           // Console.WriteLine(str==st);
            //Console.WriteLine(str.GetHashCode());

            str = str + "C#";
            Console.WriteLine(str.GetHashCode());
            Console.WriteLine(str);
            Console.ReadLine();
        }
    }
}
