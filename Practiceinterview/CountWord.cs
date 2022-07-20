using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyNewProject1.Practiceinterview
{
    class CountWord
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter the string");
            string str = Console.ReadLine();
            string[] s = str.Split(' ');
            int count = 0;
            for(int i=0;i<s.Length;i++)
            {
                count++;
            }
            Console.WriteLine(count);
            Console.ReadLine();
        }
    }
}
