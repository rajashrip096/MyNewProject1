using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyNewProject1.ArrayDemos
{
    class FrequencyofElement
    {
        static void Main(string[] args)
        {
            int[] a = { 4, 1, 3, 5, 1, 1, 4 };
            Console.WriteLine("Enter the Element");
            int num = int.Parse(Console.ReadLine());
            int count = 0;
            for(int i=0;i<a.Length;i++)
            {
                if(num==a[i])
                {
                    count++;
                }
            }
            Console.WriteLine("Occurence of " + num + "  given no is " + count) ;
            Console.ReadLine();
        }
    }
}
