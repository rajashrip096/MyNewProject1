using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyNewProject1.Assigment_5_mixprogram
{
    class MergeArrayp2
    {
        //2.Write a program to merge two sorted array of number such that new
        //array is sorted array and there should be no duplicate in new array.[1M]
        static void Main(string[] args)
        {
            int[] a = { 1, 2, 3, 4, 2 };
            int[] b = { 5, 6, 3, 1 };
            int[] c = new int[a.Length + b.Length];
            int j = 0;
            for(int i=0;i<a.Length;i++)
            {
                c[j] = a[i];
                j++;
            }
            for (int i = 0; i <b.Length; i++)
            {
                bool ispresent = false; ;
                for (int k = j - 1; k >=0 ; k++)
                {
                    if(c[k]==b[i])
                    {
                        ispresent = true;
                        break;
                    }
                }
                if(ispresent==false)
                {
                    c[j] = b[i];
                    j++;
                }
            }
            Console.WriteLine(string.Join("",a));
            Console.WriteLine(string.Join("",b));

            for(int i=0;i<j;i++)
            {
                Console.WriteLine(c[i]+ " ");
            }
            Console.ReadLine();
        }
    }
}
