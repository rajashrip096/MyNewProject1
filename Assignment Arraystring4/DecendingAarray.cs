using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyNewProject1.Assignment_Arraystring4
{
    class DecendingAarray
    {
        //4.	Create an array of 10 names sort in descending order
        static void Main(string[] args)
        {
            int[] a = { 2, 1, 4, 7, 9, 5, 92, 10, 22, 3 };
            Console.WriteLine(string.Join(" ",a));
            for(int i=a.Length-1;i>=0; i--)
            {
                Console.WriteLine(a[i]+" ");
                Console.ReadLine();

            }

            
        }
    }
    class DesendingOrder
    {
        static void Main(string[] args)
        {
            int[] a = { 2, 1, 4, 7, 9, 5, 92, 10, 22, 3 };
            Console.WriteLine(string.Join(" ", a));
            int temp;
            for(int i=0;i<a.Length;i++)
            {
                for(int j=i+1;j<a.Length;j++)
                {
                    if (a[i] < a[j])
                    {
                        temp = a[i];
                        a[i] = a[j];
                        a[j] = temp;
                    }
                }
            }

            Console.WriteLine("Decending order Array is: ");
            for (int i = 0; i < a.Length; i++)
            {
                Console.WriteLine(string.Join(" ",a[i]));
                Console.ReadLine();
            }
           
        }
    }
}
