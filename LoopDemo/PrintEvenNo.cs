using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyNewProject1.LoopDemo
{
    //write the code to print Even number
    class PrintEvenNo
    {
        static void Main(string[] args)
        {
            Console.WriteLine("list of even number");
            //Console.ReadLine();
            //Console.WriteLine("Enter the  no");
            // int n = Convert.ToInt32(Console.ReadLine());

            int n =229, sum=0;
            for(int i=121;i<=229;i++)
            {
                if(i%2==0)
                {
                    sum = sum + i;
                    Console.WriteLine(i);
                    Console.ReadLine();
                    Console.WriteLine("Sum of all even no ="+sum);
                }

            }   
            
        }
    }
}
