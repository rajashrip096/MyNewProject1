using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyNewProject1.Assignment_Arraystring4
{
    //5.	Write a program to find total number of alphabets,
    //digits or special character in a string.
    class AlphaDigitSpl
    {
        static void Main(string[] args)
        {
            Console.WriteLine("enter the string");
            string s = Console.ReadLine();
            int alphabet, digit, specialchar;
            alphabet = digit = specialchar = 0;
            for(int i=0;i<s.Length;i++)
            {
                if((s[i]>='a' && s[i]<='z')||(s[i]>='A' && s[i]<='Z'))
                {
                    alphabet++;
                }
               else if(s[i]>='0'&& s[i]<='9')
                {
                    digit++;
                }
                else
                {
                    specialchar++;
                }
                
            }
            Console.WriteLine("Alphabet is = "+alphabet);
            Console.WriteLine("Digit is = "+digit);
            Console.WriteLine("Special character is ="+specialchar);
            Console.ReadLine();
        }
    }
}
