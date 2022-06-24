using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyNewProject1.ArrayDemos
{
    class Pattern2_2DArray
    {
        static void Main(string[] args)
        {
            //char[,] a = new char[3, 3];
            int[,] a = { { 1, 2, 3, 4 }, { 5, 6, 7, 8 }, { 9, 8, 7, 6 }, { 5, 6, 7, 8 } };
            for (int i = 0; i < a.GetLength(0); i++)
            {
                for (int j = 0; j < a.GetLength(1); j++)
                {
                    if (j == 0 || (i == j) || j == a.GetUpperBound(1))
                    {
                        Console.Write("*");
                    }
                    else
                    {
                        Console.Write(" ");
                    }
                    Console.WriteLine();
                }
            }
            for (int i = 0; i < a.GetLength(0); i++)
            {
                for (int j = 0; j < a.GetLength(1); j++)
                {
                    Console.WriteLine(a[i,j]);
                    Console.ReadLine();
                }


            }
        }
    }
}
