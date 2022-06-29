using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyNewProject1.Assignment_Arraystring4
{
    class AcendingOrderArray
    {
        //1 .WAP sort array elements in ascending order
        static void Main(string[] args)
        {
            int[] a = { 8, 4, 1, 5, 3, 9, 22, 11, 2, 6 };
            Console.WriteLine(string.Join(" ",a));
            int temp;
            for(int i=0;i<a.Length;i++)
            {
                for(int j=i+1;j<a.Length;j++)
                {
                    if(a[i]>a[j])
                    {
                        temp = a[i];
                        a[i] = a[j];
                        a[j] = temp;
                    }
                }
            }
            for(int i=0;i<a.Length;i++)
            {
                Console.WriteLine(string.Join("", a[i]));
                Console.ReadLine();
            }
            
        }
    }
}
