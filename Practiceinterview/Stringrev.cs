using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyNewProject1.Practiceinterview
{
    class Stringrev
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter the string");
            string str = Console.ReadLine();
            string rev="";
            for(int i=0;i<str.Length;i++)
            {
                rev = str[i] + rev;
            }
            Console.WriteLine(rev);
            Console.ReadLine();
        }
    }
    class stringrev2
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter the no");
            string str = Console.ReadLine();
            string newstr = "";
            for(int i=str.Length-1;i>=0;i-- )
            {
                newstr = newstr + str[i];
            }
            Console.WriteLine(newstr);
            Console.ReadLine();
        }
    }
    class string3
    {
        static void Main(string[] args)
        {
            Console.WriteLine("enter the string");
            string str = Console.ReadLine();
            char[] ch = str.ToCharArray();
            string newstr= "";
            for(int i=ch.Length-1;i>=0;i--)
            {
                newstr= newstr+ ch[i];
            }
            Console.WriteLine(newstr);
            Console.ReadLine();
        }
    }
}
