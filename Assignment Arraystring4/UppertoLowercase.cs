using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyNewProject1.Assignment_Arraystring4
{
    //6.	Write a  program to convert uppercase string to lowercase
    class UppertoLowercase
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter the string");
            string s = Console.ReadLine();

            String newLower = s.ToLower();
           
            Console.WriteLine(newLower);
            Console.ReadLine();

        }
    }
    class ToggleTest
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter the string");
            string s = Console.ReadLine();
            string newstring = "";
            for (int i = 0; i < s.Length; i++)
            {
                if (char.IsUpper(s[i]))
                {
                    newstring = newstring + char.ToLower(s[i]);
                }
                else if (char.IsLower(s[i]))
                {
                    newstring = newstring + char.ToUpper(s[i]);
                }
                else
                {
                    newstring = newstring + s[i];
                }

            }
            Console.ReadLine();
        }
    }
}
