using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyNewProject1.ArrayDemos
{
    class CharacterArrayDemo
    {
        static void Main(string[] args)
        {
            char[] ch = { 'a', 'r', 't', 'p' };

            char[] ch1 = new char[4];
            for(int i=0;i<ch1.Length;i++)
            {
                ch[i] = Convert.ToChar(Console.ReadLine());
               
            }
            Console.WriteLine(string.Join(" ",ch));
          
            Console.ReadLine();

        }
    }
}
