using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyNewProject1.Assignment_Array_3
{
    class Square
    {
        static void Main(string[] args)
        {
            int count = 0;
            int[] a = { 1, 2, 4, 5, 9, 25 };
            for(int i=0;i<a.Length;i++)
            {
                int square = a[i] * a[i];
                for(int j=0;j<a.Length;j++)
                {
                    if(a[j]==square)
                    Console.WriteLine(a[i]);
                    Console.ReadLine();
                }

            }
        }
    }




}
