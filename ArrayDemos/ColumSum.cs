   using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyNewProject1.ArrayDemos
{
    class ColumSum
    {
        static void Main(string[] args)
        {
            int[,] a = { { 1, 2, 3 }, { 4, 7, 5 }, { 8, 9, 4 } };
            for (int i = 0; i < a.GetLength(0); i++)
            {
                int sum = 0;
                for (int j = 0; j < a.GetLength(1); j++)
                {
                    sum = sum + a[j, i];
                    Console.WriteLine(a[j, i] + " ");
                }
                Console.Write("sum is = " + sum);
                Console.WriteLine();
                Console.ReadLine();
            }
        }
    }
}
