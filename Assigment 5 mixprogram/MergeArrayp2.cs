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
            Console.WriteLine("Enter the size of two array");
            int size1 = int.Parse(Console.ReadLine());
            int size2 = int.Parse(Console.ReadLine());

            int[] a1 = new int[size1];
            int[] a2 = new int[size2];
            Console.WriteLine("Enter the first Array");
            for(int i=0;i<a1.Length;i++)
            {
                a1[i] = int.Parse(Console.ReadLine());
            }
            Console.WriteLine(string.Join(" ",a1));
            Console.WriteLine("Enter the second Array");
            for(int i=0;i<a2.Length;i++)
            {
                a2[i] = int.Parse(Console.ReadLine());
            }
            Console.WriteLine(string.Join(" ",a2));

            int[] merged = new int[size1 + size2];
            int j = 0;
            int k = 0;
            for(int i=0;i<merged.Length;i++)
            {
                if (i < a1.Length)
                {
                    merged[i] = a1[j];
                    j++;
                }
                else
                {
                    merged[i] = a2[k];
                    k++;
                }
            }
            Array.Sort(merged);
            Console.WriteLine("Merged Array is :");
            Console.WriteLine(string.Join(" ",merged));
            Console.WriteLine();

            HashSet<int> d = new HashSet<int>();
            for (int i = 0; i < merged.Length; i++)
                d.Add(merged[i]);
            Console.WriteLine("sorted ne array:");
            Console.WriteLine(string.Join(" ",d));
            Console.ReadLine();
        }
    }
}
