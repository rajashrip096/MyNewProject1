using System;

namespace MyNewProject1.Assignment_Arraystring4
{
    //1. WAP to replace all the 0’s with 1’s in your array.
    //Your array is [26, 0, 67, 45, 0, 78, 54, 34, 10, 0, 34].
    class ReplaceAllZero
    {
        static void Main(string[] args)
        {
            int[] a = new int[10];
            int[] a1 = new int[a.Length];
            Console.WriteLine("Enter the array element");
            for (int i = 0; i < a.Length; i++)
            {
                a[i] = Convert.ToInt32(Console.ReadLine());
            }

            for (int i = 0; i < a.Length; i++)
            {
                if (a[i] == 0)
                {
                    a1[i] = 1;
                }
                else
                {
                    a1[i] = a[i];
                }
            }
            Console.WriteLine(string.Join(" ", a1));
            Console.ReadLine();
        }
    }
}
