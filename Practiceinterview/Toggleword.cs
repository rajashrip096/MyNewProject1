using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyNewProject1.Practiceinterview
{
    class Toggleword
    {
        public static string Check(string str)
        {
            string newstr = "";
            for(int i=0;i<str.Length;i++)
            {
                if(str[i] >='A' && str[i]<='Z')
                {
                    newstr = newstr + ((char)(str[i] + 32));
                }
                else if(str[i]>='a' && str[i]<='z')
                {
                    newstr = newstr + ((char)(str[i] - 32));
                }
                else
                {
                    newstr = newstr + str[i];
                }
            }
            return newstr;

        }
        
        static void Main(string[] args)
        {
            Console.WriteLine("Enter the string");
            string s = Console.ReadLine();
            Console.WriteLine(Check(s));
            Console.ReadLine();
        }
    }
    class Togglecase2
    {
        public static string Toword(string str)
        {
            string newstr = "";
            for(int i=0;i<str.Length;i++)
            {
                if(char.IsUpper(str[i]))
                {
                    newstr = newstr + (char.ToLower(str[i]));
                }
                else if(char.IsLower(str[i]))
                {
                    newstr = newstr + (char.ToUpper(str[i]));
                }
                else
                {
                    newstr = newstr + str[i];
                }
            }
            return newstr;
        }
        static void Main(string[] args)
        {
            Console.WriteLine("Enter the string");
            string s = Console.ReadLine();
            Console.WriteLine(Toword(s));
            Console.ReadLine();
        }
    }
}
