using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyNewProject1.Assignment_1
{
    class Pattern1
    {
        //* * * *
        //*     *
        //*     *
        //* * * * 
        static void Main(string[] args)
        {
            for(int i=1;i<=4;i++)
            {
                for(int j=1;j<=4;j++)
                {
                    if (i == 1 || i == 4 || j == 1 || j == 4)
                    {
                        Console.WriteLine("*");
                        Console.ReadLine();
                    }

                    else
                    {
                        Console.WriteLine(" ");
                    }
                }
                Console.WriteLine();
            }
        }
    }
    class Pattern2
    {
        static void Main(string[] args)
        {
            /* *
                * *
                * * *
                * * * *  */
             
            /*
             * for (int i = 1; i<=4; i++)
            {
                for(int k=4;k>=1;k--)
                { 
                    Console.WriteLine(" ");
                }
                for(int j=0;j<i;j++)
                {
                    Console.WriteLine( "*");
                    Console.ReadLine();
                }
                    Console.WriteLine();

            }*/

            /* *
               * *
               *    *
               *      *
               * * * * *  */
               for(int i=1;i<=5;i++)
            {
                for(int j=1;j<=i;j++)
                {
                    if (j == 1 || j == i||i==5)

                    {
                        Console.WriteLine("*");
                        Console.ReadLine();
                    }
                    else
                    {
                        Console.WriteLine(" ");
                        Console.ReadLine();
                    }
                    Console.WriteLine();
                }
            }
        }
    }
}
