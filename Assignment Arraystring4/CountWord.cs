using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyNewProject1.Assignment_Arraystring4
{
    class CountWord
    {
        //2.Write a program to count the number of words in a string
        static void Main(string[] args)
        {
            Console.WriteLine("Enter the string");
            string s = Console.ReadLine();
            string[] s1 = s.Split(' ');
            int count = 0;
            for(int i=0;i<=s.Length;i++)
            {
                count++;
            }
            Console.WriteLine(count);
            Console.ReadLine();
        }
    }
}
