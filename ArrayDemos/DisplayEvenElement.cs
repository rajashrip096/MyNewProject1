using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyNewProject1.ArrayDemos
{
    class DisplayEvenElement
    {
        static void Main(string[] args)
        {
            int[] a = { 5, 8, 2, 1, 11, 6, 0 };
            //Display even element from array
            for(int i=0;i<a.Length;i++)
            {
                if(a[i]%2==0)
                {
                    Console.WriteLine(a[i]);
                }
                Console.WriteLine(string.Join(" ",a));
                Console.ReadLine();
            }
            
        }
    }
}
