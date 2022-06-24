using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyNewProject1.Assignment_Array_3
{
    class Replacezero
    {
        static void Main(string[] args)
        {
            int[] a = { 26, 0, 67, 45, 0, 78, 54, 34, 10, 0, 34 };
           int[] a1 = new int[a.Length];
           Console.WriteLine("enter the element of array");
            for(int i=0;i<a1.Length;i++)
            {
                if(a[i]==0)
                {
                    a1[i] = 1;
                }
                else
                {
                    a1[i] = a[i];
                }
            }
            Console.WriteLine(string.Join ("",a1));
            Console.ReadLine();
            
        }
    }
}
