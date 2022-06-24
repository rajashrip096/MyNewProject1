using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyNewProject1.Assignment_Array_3
{
    class SeparetZeroandnonzero
    {
        //Write a  program to separate zeros from non-zeros in an integer array
        static void Main(string[] args)
        {
            int[] a = new int[6];
            Console.WriteLine("Enter the element of array");
            for(int i=0;i<a.Length;i++)
            {
                a[i] = int.Parse(Console.ReadLine());
            }
            Console.WriteLine(string.Join(" ",a));
            int pos = 0;
            for(int i=0;i<a.Length;i++)
            {
                if(a[i]!=0)
                {
                    a[i] = a[pos];
                    pos++;
                }
                while(pos<a.Length)
                {
                    a[pos] = 0;
                    pos++;
                }
                Console.WriteLine(string.Join("",a));
                Console.ReadLine();
            }
        }
    }
}
