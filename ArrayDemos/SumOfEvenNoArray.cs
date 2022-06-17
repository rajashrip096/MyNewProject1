using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyNewProject1.ArrayDemos
{
    class SumOfEvenNoArray
    {
        static void Main(string[] args)
        {
            int[] a = { 1, 2, 3, 4, 6, 5, 7, 8 };
            int sum = 0;
            for(int i=0;i<a.Length;i++)
            {
                if(a[i]%2==0)
                {
                    Console.WriteLine(a[i]);
                    sum = sum + a[i];
                    Console.WriteLine(sum);
                }
               
            }
            Console.ReadLine();
        }
    }
}
