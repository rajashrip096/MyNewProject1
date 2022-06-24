using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyNewProject1.ArrayDemos
{
    class TwoDArraySum
    {
        static void Main(string[] args)
        {
            int[,] a = { { 1, 2, 3 }, { 4, 6, 5 }, { 8, 9, 5 } };
            for(int i=0;i<a.GetLength(0);i++)
            {
                int sum = 0;
                for(int j=0;j<a.GetLength(1);j++)
                {
                    sum = sum + a[i, j];
                    Console.WriteLine(a[i,j]+" ");
                }
                Console.Write(" Sum is  "+sum);
                Console.WriteLine();
                Console.ReadLine();
            }
        }
    }
}
