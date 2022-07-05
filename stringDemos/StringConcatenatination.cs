using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyNewProject1.stringDemos
{
    class StringConcatenatination
    {
        static void Main(string[] args)
        {
            string str1 = "Hello";
            string str2 = "C#";
            string str;
            Console.WriteLine(str1);
            Console.WriteLine(str2);
            str = string.Concat(str1, str2);
            Console.WriteLine(str);
            Console.ReadLine();
        }
    }
}
