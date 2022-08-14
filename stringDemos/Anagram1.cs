using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyNewProject1.stringDemos
{
    class Anagram1
    {
        public static bool check(string str1,string str2)
        {
            if(str1==str2)
            {
                string s1 = str1.ToLower();
                string s2 = str2.ToLower();
                char[] ch1 = s1.ToCharArray();
                char[] ch2 = s2.ToCharArray();
                Array.Sort(ch1);
                Array.Sort(ch2);
                if(ch1==ch2)
                {
                    return true;
                }
                else
                {
                    return false;
                } 
            }
            else
            {
                return false;
            }
        }
        static void Main(string[] args)
        {
            string str1 = Console.ReadLine();
            string str2 = Console.ReadLine();
            bool isAnagram = Anagram1.check(str1 , str2);
            if(isAnagram==true)
            {
                Console.WriteLine("string is anagram");
            }
            else
            {
                Console.WriteLine("String is Anagram");
            }
            Console.ReadLine();
        }
    }
}
