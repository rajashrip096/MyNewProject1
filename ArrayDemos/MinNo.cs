using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyNewProject1.ArrayDemos
{
    class MinNo
    {
        static void Main(string[] args)
        {
            int[] a = { 11, 2, 92, 10, 88, 67 };
            int min = a[0];
           
            for (int i = 0; i < a.Length; i++)
            {
               
                if (a[i] < min)
                {
                    min = a[i];
                }
            }
            Console.WriteLine("Minimun No is   " + min);
            Console.ReadLine();
        }
    }
    
}
