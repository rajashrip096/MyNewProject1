using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyNewProject1.ArrayDemos
{
    class ArrayCreation
    {
        static void Main(string[] args)
        {
           
           //int x;
           /* x = 23;
            int x = 1;
            int y = 2;
            int z = 56;
            int p = 78;
            int[] arr = { 7, 9, 8, 2, 1, 3 };*/
            int[] a = new int[5]; //Declaration
            /*1.
                a[0] = 44;
            a[1] = 20;
            a[2] = 23;
            a[3] = 78;
            a[4] = 4;*/
            Console.WriteLine("Enter the array element");
            for(int i=0;i<a.Length;i++)
            {
             // int x = Convert.ToInt32(Console.ReadLine());
               // a[i] = x;
                a[i] = Convert.ToInt32(Console.ReadLine());
            }
            Console.WriteLine("//////////////////////////////////");
            for(int i=0;i<a.Length;i++)
            {
                Console.Write(a[i]+" ");
            }
            Console.WriteLine();
            Console.WriteLine("//////////////////////////////////////");
            foreach(int x in a)
            {
                Console.WriteLine(x);
            }
            Console.WriteLine("////////////////////////////////////////");
            Console.WriteLine(string.Join(" ",a));
            Console.ReadLine();
        }
    }
}
