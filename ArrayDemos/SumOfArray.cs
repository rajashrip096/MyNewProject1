using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyNewProject1.ArrayDemos
{
    class SumOfArray
    {
        static void Main(string[] args)
        {
            int[] b = { 2, 3, 4, 5, 6, 7 };
            int sum = 0;

            for(int i=0;i<b.Length;i++)
            {
                sum = sum + b[i];
                Console.WriteLine(b[i]+ "  "+sum);
                //Console.WriteLine(sum);
            }
            Console.ReadLine();
        }
    }
}
