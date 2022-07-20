
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyNewProject1.Practiceinterview
{
    class ReverseARray1
    {
        static void Main(string[] args)
        {
            int[] a = { 8, 3, 5, 2, 9, 2, 4 };
            int j = a.Length - 1;
            Console.WriteLine(string.Join("  ", a));
            for(int i=0;i<a.Length/2;i++)
            {
                int temp = a[i];
                a[i] = a[j];
                a[j] = temp;
                j--;
            }
            Console.WriteLine(string.Join("  ", a));
            Console.ReadLine();
        }
    }
}
