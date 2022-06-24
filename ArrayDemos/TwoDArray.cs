using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyNewProject1.ArrayDemos
{
    class TwoDArray
    {
        static void Main(string[] args)
        {
            int[,] arr = { { 2,6,3},
                          {8,1,9 },
                           {4,5,3 }};
           // int[,] a = new int[2, 2] { { 3, 6 }, { 6, 8 } };
            int[,] a = new int[3, 3];
            Console.WriteLine("Enter the array element");
            for(int i=0;i<a.GetLength(0);i++)
            {
                for(int j=0;j<a.GetLength(1);j++)
                {
                   // int x = int.Parse(Console.ReadLine());
                    //a[i, j] = x;
                    a[i, j] = int.Parse(Console.ReadLine());
                }
            }
            Console.WriteLine(".....................................");
            for(int i=0;i<a.GetLength(0);i++)
            {
                for(int j=0;j<a.GetLength(1);j++)
                {
                    Console.WriteLine(a[i,j]+" ");
                }
                Console.ReadLine();
            }
        }
    }
}
