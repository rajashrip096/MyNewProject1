﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyNewProject1.LoopDemo
{
    class OddEvenTest
    {
        static void Main(string[] args)
        {

           
            int n = Convert.ToInt32(Console.ReadLine());

            if (n % 2 != 0)
            {
                Console.WriteLine("Weird");
                Console.ReadLine();
            }
            else if(n%2==0 && (n>=2 && n<=5))
            {
                Console.WriteLine("Not Weird");
                Console.ReadLine();
            }
            else if(n%2==0 && (n<=6 && n>=20) )
            {
                Console.WriteLine("Weird");
                Console.ReadLine();
            }
            else
            {
                Console.WriteLine("Not Weird");
                Console.ReadLine();
            }
        }

    }
}
