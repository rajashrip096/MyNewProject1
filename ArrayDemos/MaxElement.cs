using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyNewProject1.ArrayDemos
{
    class MaxElement
    {
        static void Main(string[] args)
        {
            char[] c = { 'a', 'r', 't', 'Y', 'q' };
            char max = c[0];
            int x = 0;
            for(int i=0;i<c.Length;i++)
            {
                x = c[i];
                Console.WriteLine(c[i]+" "+x);
                if(c[i]>max)
                {
                    max = c[i];
                }
            }
            Console.WriteLine("//////////////////////////////////////");
            Console.WriteLine("Max "+max);
            Console.ReadLine();
        }
    }
}
