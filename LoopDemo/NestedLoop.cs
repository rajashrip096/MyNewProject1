using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyNewProject1.LoopDemo
{
    class NestedLoop
    {
        static void Main(string[] args)
        {
            //Print jj jj jj
            /* for (int i = 1; i <= 3; i++)
             {
                 for (int j = 1; j <= 2; j++)
                 {
                     Console.WriteLine("j");
                     Console.ReadLine();
                 }
                 Console.WriteLine();
             } */
            /* * * * *
               * * * *
               * * * *
               * * * *  */

            /*for (int i = 1; i <= 4; i++)
            {
                for (int j = 1; j <= 4; j++)
                {
                    Console.WriteLine("*");
                    Console.ReadLine();
                }
                Console.WriteLine();

            }*/

            for(int i=1;i<=4;i++)
            {
                for(int j=1;j<=i;j++)
                {
                    Console.WriteLine(" * ");
                    Console.ReadLine();
                }
                Console.WriteLine();
            }
        }
    }
}
