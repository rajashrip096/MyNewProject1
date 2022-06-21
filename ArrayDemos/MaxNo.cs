using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyNewProject1.ArrayDemos
{
    class MaxNo
    {
        static void Main(string[] args)
        {
            //int[] a = { 11, 2, 92, 10, 88, 67 };
            int[] a = new int[5];
            Console.WriteLine("Enter the number");
          
            int max = a[0];
            
            for (int i = 0; i < a.Length; i++)
            {
                a[i] = int.Parse(Console.ReadLine());

                if (a[i] >max)
                {
                    max = a[i];
                }
            }
            Console.WriteLine("Maximun No is   " + max);
            Console.ReadLine();
        }
    }
}
