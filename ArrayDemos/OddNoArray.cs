using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyNewProject1.ArrayDemos
{
    class OddNoArray
    {
        static void Main(string[] args)
        {
            int[] a = { 1, 2, 3, 54, 7, 8, 85, 9, 81, 7 };

            for(int i=0;i<a.Length;i++)
            {
                if(a[i]%2!=0)
                {
                    Console.WriteLine(a[i]);
                   
                }
            }
            Console.ReadLine();
        }
    }
}
