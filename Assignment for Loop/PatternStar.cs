﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyNewProject1.Assignment_for_Loop
{
    //WAP to print following pattern. 
    //  * * * * *
    //   * * * *
    //    * * *
    //     * *
    //      *
    class PatternStar
    {
        static void Main(string[] args)
        {
           for(int i=1;i<=5;i++)
            {
                for(int j=1;j<=i; j++)
                {
                    Console.Write("*");
                }
                Console.WriteLine();
            }
            Console.ReadLine();
        }
    }
}
