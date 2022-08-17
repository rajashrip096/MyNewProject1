using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyNewProject1.Assigment_5_mixprogram
{
    /*5.Reverse middle words of a string[1M]
    Given a string str, print reverse all words except the first and last words.

    Examples:
    Input  : Hi how are you students
    Output  : Hi woh era uoy students
    Input : I am fine
    Output : I ma fine*/

    class Reversestring
    {
        public static string revemiddle(string str)
        {
            string[] s = str.Split(' ');
            string revword = " ";
            for (int i = 0; i < s.Length; i++)
            {
                if (i == 0 || i == s.Length - 1)
                {
                    revword = revword + s[i];
                }
                else
                {
                    string word = s[i];
                    string reverseword = "  ";
                    for (int j = word.Length - 1; j >= 0; j--)
                    {
                        reverseword = reverseword + word[j];
                    }
                    revword  = "   "  +  revword  +  "    "  + reverseword;
                }
            }
            return revword;

        }
        static void Main(string[] args)
        {
            Console.WriteLine("Enter the string");
            string s = Console.ReadLine();
            string rev = revemiddle(s);
            Console.WriteLine(rev);
            Console.ReadLine();
        }
    }
}
