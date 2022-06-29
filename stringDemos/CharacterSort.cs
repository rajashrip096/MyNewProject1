using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyNewProject1.stringDemos
{
    class CharacterSort
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter the string");
            string s = Console.ReadLine();
            string[] str = s.Split(' ');
            for(int i=0;i<str.Length-1;i++)
            {
                for(int j=0;j<str.Length-1;j++)
                {
                    if (str[i].CompareTo(str[j])==1)
                    {
                        string temp = str[i];
                        str[i] = str[j];
                        str[j] = temp;
                    }
                }
            }
            Console.WriteLine(string.Join(" ",str));
            Console.ReadLine();
        }
    }
}
