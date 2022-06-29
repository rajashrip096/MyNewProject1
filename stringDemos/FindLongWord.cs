using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyNewProject1.stringDemos
{
    class FindLongWord
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter the string");
            string str = Console.ReadLine();
            string[] s = str.Split(' ');
            int maxlength = 0;
            string longestword = "";
            for(int i=0;i<s.Length;i++)
            {
                maxlength = s[i].Length;
                longestword = s[i];
            }
            for(int i=0;i<s.Length;i++)
            {
                if(maxlength==s[i].Length)
                {
                    Console.WriteLine(s[i]);
                }
            }
            Console.WriteLine(longestword+" "+maxlength);
            Console.ReadLine();
        }
    }
}
