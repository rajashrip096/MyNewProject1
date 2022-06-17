using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyNewProject1.Assignment_for_Loop
{
    //WAP to print following pattern. 
  /*  1 2 3 4 5
         1 2 3 4
             1 2 3
                1 2
                    1*/
    class PatternNo2
    {
        static void Main(string[] args)
        {
            for(int i=1;i<=5;i++)
            {
                for(int j=1;j<=i;j++)
                {
                    Console.Write(j);
                }
                Console.WriteLine();
            }
           

           /* for (int i = 5; i >= 1; i-=1)
            {
                for (int j = 1; j <= i; j++)
                {
                    Console.Write(j);
                }
                Console.WriteLine();
            }*/



            Console.ReadLine();
        }
    }
}
