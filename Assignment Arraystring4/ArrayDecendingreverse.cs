using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyNewProject1.Assignment_Arraystring4
{
    class ArrayDecendingreverse
    {
       // 1.	WAP to reverse the array itself, don’t print array in reverse –
       // I want current array reverse.Means e.g.arr[] = [3, 90, 45, 29, 37, 78]
       // so your same array must be [78, 37, 29, 45, 90, 3] without using temporary array
        static void Main(string[] args)
        {
            int[] a = { 2, 1, 4, 7, 9, 5 };
            Console.WriteLine(string.Join(" ", a));
            for (int i = a.Length - 1; i >= 0; i--)
            {
                Console.WriteLine(a[i] + " ");
                Console.ReadLine();

            }
        }
    }
}
