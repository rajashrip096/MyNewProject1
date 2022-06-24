using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyNewProject1.stringDemos
{
    class StringPattern
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter the string");
            string str = Console.ReadLine();
            for(int i=0;i<str.Length-1;i++)
            {
                for(int j=0;j<=i;j++)
                {
                    Console.WriteLine(str[j]);
                }
            }
            Console.ReadLine();
        }
    }
}
