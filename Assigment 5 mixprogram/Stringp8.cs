using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyNewProject1.Assigment_5_mixprogram
{
    /*8.	WAP to accept a string and make following changes [1M]
        •	Shift each letter right by two step eg A ->C ,Y->A,Z->B
        •	Each digit by next higher digit.
        •	Space by underscore*/
    class Stringp8
    {
        static void Main(string[] args)
        {
            Console.WriteLine("enter the string");
            string nm = Console.ReadLine().ToUpper();
            int step = 4;
            int newchar = 0;
            foreach(char ch in nm)
            {
                if(char.IsLetter(ch))
                {
                    newchar = ch + step;
                    if(newchar>90)
                    {
                        newchar = newchar - 26;
                    }
                }
                else if(char.IsDigit(ch))
                {
                    newchar = ch;
                    newchar++;
                }
                Console.Write((char)newchar);
               
            }
            Console.ReadLine();
        }
    }
}
