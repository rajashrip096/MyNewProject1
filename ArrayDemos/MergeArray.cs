using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyNewProject1.ArrayDemos
{
    class MergeArray
    {
        static void Main(string[] args)
        {
            int[] a = { 11, 22, 33, 44 };
            int[] b = { 1, 2, 3, 4, 22 };
            int[] c = new int[a.Length + b.Length];
            int j = 0;
                            
            for(int i=0;i<a.Length;i++)
            {
                c[j] = a[i];
                j++;
            }
            for(int i=0;i<b.Length;i++)
            {
                bool isPresent = false;
                for(int k=j-1;k>=0;k--)
                {
                    if (c[k] == b[i])
                    {
                        isPresent = true;
                        break;
                    }
                }
                if (isPresent == false)
                {
                    c[j] = b[i];
                    j++;
                }
            }
            
            Console.WriteLine(string.Join(" ", a));
            Console.WriteLine(string.Join(" ",b));
            for(int i=0;i<j;i++)
            {
                Console.WriteLine(c[i]+" ");
            }
         
           
            Console.ReadLine();
        }
    }
}
