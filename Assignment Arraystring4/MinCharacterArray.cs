using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyNewProject1.Assignment_Arraystring4
{
    class MinCharacterArray
    {
        //1.	WAP to find min character in character array. Means
        //e.g. arr[] = [‘A’, ‘D’, ‘E’, ‘x’, ‘z’, ‘R’], so min character is ‘A’
        static void Main(string[] args)
        {
            char[] ch = {'A','D','E','x','z','R'};
            char min = ch[0];
            for(int i=0;i<ch.Length;i++)
            {
                if(ch[i]<min)
                {
                    min = ch[i];
                }
            }
            Console.WriteLine("Minimum character is "+min);
            Console.ReadLine();

        }
    }
}
