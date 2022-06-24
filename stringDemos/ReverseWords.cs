using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyNewProject1.stringDemos
{
    class ReverseWords
    {
        public static string ReverseEachWords(string str)
        {
            string[] s = str.Split(' ');
            string reverse = "";
            for (int i = 0; i < s.Length; i++)
            {
                string word = s[i];
                string reverseword = " ";
                for (int j = word.Length - 1; j >= 0; j--)
                {
                    reverseword = reverseword + word[j];
                }
                reverse = reverse + " " + reverseword;
            }
            return reverse;
        }
        static void Main(string[] args)
        {
            Console.WriteLine("enter the string");
            string s = Console.ReadLine();
            string reversenew = ReverseEachWords(s);
            Console.WriteLine(reversenew);
            Console.ReadLine();
        }
    }
}
