using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyNewProject1.Assignment_Arraystring4
{
    class SumOfNo
    {
        //Write a  program to enter two numbers and find their sum.
        static void Main(string[] args)
        {
            int[] a = { 1, 2, 3, 4 };
            int sum = 0;
            for(int i=0;i<a.Length;i++)
            {
                sum = sum + a[i];
            }
            Console.WriteLine(string.Join(" ",a));
            Console.WriteLine("sum is = "+sum);
            Console.ReadLine();
        }
    }
}
