using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyNewProject1.stringDemos
{
    class Test
    {
        static void Main(string[] args)
        {
            int sum = 0;
            for (int i = 0; i <= 5; i++)
            {
                sum = sum + i;
            }
            Console.WriteLine(sum);
            Console.ReadLine();
        }
       
     
    }
    class Testrevision
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter the string");
            string str = Console.ReadLine();
            string rev = "";
            for(int i=str.Length-1;i>=0;i--)
            {
                rev = rev + str[i];
            }
            Console.WriteLine(rev);
            Console.ReadLine();
        }
    }
    class Revisionrev1
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter the string");
            string str = Console.ReadLine();
            string reverse = "";
            for(int i=0;i<str.Length;i++)
            {
                reverse = str[i] + reverse;
            }
            Console.WriteLine(reverse);
            Console.ReadLine();
        }
    }
    class Revisionrev2
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter the string");
            string str = Console.ReadLine();
            char[] ch = str.ToCharArray();
            string rev = "";
            for(int i=ch.Length-1;i>=0;i--)
            {
                rev = rev + ch[i];
            }
            Console.WriteLine(rev);
            Console.ReadLine();
        }
    }
}
