using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyNewProject1.LoopDemo
{
    //printy  even nob & square of odd number
    class PrintNo1To10WhileLoop
    {
        static void Main(string[] args)
        {
            int i = 1;


            while (i <= 10)
            {

                if (i % 2 == 0)
                {
                    Console.WriteLine("Number is even");
                    //Console.ReadLine();

                }
                else if (i % 2 == 1)
                {

                    Console.WriteLine("odd no  " + (i * i));
                   
                }
                i++;
            }
            Console.ReadLine();
        }
    }
}
