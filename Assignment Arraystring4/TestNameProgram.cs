using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyNewProject1.Assignment_Arraystring4
{
    class TestNameProgram
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter the name");
            string s = Console.ReadLine();
            string[] str = s.Split(' ');
            for(int i=0;i<=str.Length;i++)
            {
                if(s[i]%2==0)
                {
                    Console.WriteLine("*");
                    Console.ReadLine();
                }
            }
            Console.WriteLine(s);
        }
    }
}
