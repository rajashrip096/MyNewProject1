using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyNewProject1.stringDemos
{
    class Class10
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter the string");
            string s = Console.ReadLine();
            string[] s1 = s.Split(' ');
            int count = 0;
            for (int i = 0; i <= s.Length; i++)
            {
                count++;
            }
            Console.WriteLine(count);

            Console.ReadLine();
        }
    }
}
