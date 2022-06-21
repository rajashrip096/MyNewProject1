using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyNewProject1.ArrayDemos
{
    class RevArray2
    {
        public int[] ReversArray(int []revers)
        {
            int j = revers.Length - 1;
            for(int i=0;i<revers.Length/2;i++)
            {
                int temp = revers[i];
                revers[i] = revers[j];
                revers[j] = temp;
                j--;
            }
            return revers;
        }
        static void Main(string[] args)
        {
            int[] a = { 8, 3, 5, 1, 2 };

            Console.WriteLine(string.Join(" ", a));

            RevArray2 r = new RevArray2();
            int[] b = r.ReversArray(a);
            Console.WriteLine("Reverse Array is "+ string.Join(" ",b));
            Console.ReadLine();
        }
    }
}
