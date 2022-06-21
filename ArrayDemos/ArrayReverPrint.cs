using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyNewProject1.ArrayDemos
{
    class ArrayReverPrint
    {
        static void Main(string[] args)
        {
            //display array in revers order
            int[] a = { 2, 5, 3, 7, 9 };
            Console.WriteLine(string.Join(" ",a));
            Console.ReadLine();
            for(int i=a.Length-1;i>=0; i--)
            {
                Console.WriteLine(a[i]+" ");
                Console.ReadLine();
            }
        }
    }
}
