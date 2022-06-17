using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyNewProject1.Assignment_for_Loop
{
    //Write a program to print all numbers between 1 and 100 except
    //the numbers which are divisible by 5 or 10

    class PrintNo1to100
    {
        static void Main(string[] args)
        {
            //Console.WriteLine("Enter the number");
            //int num = Convert.ToInt32(Console.ReadLine());
            for (int i = 1; i <= 100; i++)
            {
                if(i%5!=0 && i%10!=0)
                {
                    Console.WriteLine(i+" ");
                }
               
            }
            Console.ReadLine();
        }
    }
}
