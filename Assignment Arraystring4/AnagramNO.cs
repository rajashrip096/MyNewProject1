using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyNewProject1.Assignment_Arraystring4
{
    class AnagramNO
    {
        static void Main(string[] args)
        {
            // string str1 = "heater";
            //string str2 = "reheat";
            string str1 = Console.ReadLine();
            string str2 = Console.ReadLine();
            char[] ch1 = str1.ToLower().ToCharArray();
            char[] ch2 = str2.ToLower().ToCharArray();
            Array.Sort(ch1);
            Array.Sort(ch2);
            string val1 = new string(ch1);
            string val2 = new string(ch2);
            if(val1==val2)
            {
                Console.WriteLine("Anagram");
            }
            else
            {
                Console.WriteLine("not anagrm");
            }
            Console.ReadLine();
        }
    }
    class Anagram2
    {
        static void Main(string[] args)
        {
            /*public */string anagramCheck(string input1, string input2)
            {
                string st1 = Console.ReadLine();
                string st2 = Console.ReadLine();
                char[] a = input1.ToCharArray();
                char[] a1 = input2.ToCharArray();
                Array.Sort(a);
                Array.Sort(a1);
                string s1 = new string(a);
                string s2 = new string(a1);

                if (s1.CompareTo(s2) == 0)
                {
                    return "yes";
                }
                else
                {
                    return "No";
                }
                throw new NotImplementedException("method anagramCheck(string input1, string input2)");
                Console.ReadLine();
            }
        }
       
    }
}
