using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyNewProject1.stringDemos
{
    class StringReverse
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter the string");
            string str = Console.ReadLine();
            char[] ch = str.ToCharArray();

            string reverse = "";
            for(int i=ch.Length-1;i>=0;i--)
            {
                reverse = reverse + ch[i];
            }
            Console.WriteLine(reverse);
            Console.ReadLine();
        }
    }
    class stringReverse2
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter the string");
            string str = Console.ReadLine();

            string reverse = "";
            for(int i=str.Length-1;i>=0;i--)
            {
                reverse = reverse + str[i];
            }
            Console.WriteLine(reverse);
            Console.ReadLine();
        }
    }
    class stringReverse3
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter the string");
            string str = Console.ReadLine();
            string reverse = "";
            for(int i=0;i<str.Length;i++)
            {
                reverse = str[i]+reverse;

            }
            Console.WriteLine(reverse);
            Console.ReadLine();
        }
    }
}
