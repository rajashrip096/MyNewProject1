using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyNewProject1.ArrayDemos
{
    class ReverseArray
    {
        static void Main(string[] args)
        {
            int[] a = { 5, 3, 9, 4, 1 };
            int j = a.Length - 1;
            Console.WriteLine(string.Join(" ",a));
            for(int i=0;i<a.Length/2;i++)
            {
                int temp = a[i];
                a[i] = a[j];
                a[j] = temp;
                j--;
            }
            Console.WriteLine();
            Console.WriteLine(string.Join(" ",a));
            Console.ReadLine();
        }
    }
}
