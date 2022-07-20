using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyNewProject1.stringDemos
{
    class ToggleWord
    {
        public static string Toggleword(string str)
        {
            string newcasestr = "";
            for(int i=0;i<str.Length;i++)
            {
                if(str[i]>='A' && str[i]<='Z')
                {
                    newcasestr = newcasestr + ((char)(str[i] + 32));
                }
                else if(str[i]>='a' && str[i]<='z')
                {
                    newcasestr = newcasestr + ((char)(str[i] - 32));
                }
                else
                {
                    newcasestr = newcasestr + str[i];
                }
            }
            return newcasestr;
        }

        static void Main(string[] args)
        {
            Console.WriteLine("Enter the string");
            string s = Console.ReadLine();
            Console.WriteLine(Toggleword(s));
            Console.ReadLine();

        }
    }
    class Togglecase
    {
        public static string Changestr(string str)
        {
            string newString = "";
            for (int i = 0; i < str.Length; i++)
            {
                if (char.IsUpper(str[i]))
                {
                    newString = newString + char.ToLower(str[i]);
                }
                else if (char.IsLower(str[i]))
                {
                    newString = newString + char.ToUpper(str[i]);
                }
                else
                {
                    newString = newString + str[i];
                }
            }
            return newString;
        }
        static void Main(string[] args)
        {
            Console.WriteLine("Enter the string");
            string s = Console.ReadLine();
            Console.WriteLine(Changestr(s));
            Console.ReadLine();

        }

    }
}
