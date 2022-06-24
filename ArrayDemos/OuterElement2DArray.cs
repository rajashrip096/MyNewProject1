using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyNewProject1.ArrayDemos
{
    class OuterElement2DArray
    {
        static void Main(string[] args)
        {
            int[,] a = { { 2, 4, 5, 6 }, { 7, 6, 5, 4 }, { 9, 8, 7, 5 }, { 9, 5, 3, 2 } };
            for(int i=0;i<a.GetUpperBound(0);i++)
            {
                for(int j=0;j<a.GetUpperBound(1);j++)
                {
                    Console.Write(a[i,j]);
                }
                Console.WriteLine();
            }
            Console.WriteLine(".........................................");
            for(int i=0;i<a.GetUpperBound(0);i++)
            {
                for(int j=0;j<a.GetUpperBound(1);j++)
                {
                    if(i==0 || j==0 || i==a.GetUpperBound(0) || j==a.GetUpperBound(1))
                    {
                        Console.Write(a[i,j]);
                    }
                    else
                    {
                        Console.Write(" ");
                    }
                    Console.WriteLine();
                }
                
            }
            Console.ReadLine();
        }
    }
}
