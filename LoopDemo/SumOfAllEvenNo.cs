using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyNewProject1.LoopDemo
{
    //write the code sum of all even number
    class SumOfAllEvenNo
    {
        static void Main(string[] args)
        {
            int i, num1, sum = 0;
            //num1 = 10;
            Console.WriteLine("Enter the  no");
            num1 = Convert.ToInt32(Console.ReadLine());
            for(i=2; i<= num1; i++)
            {
                if (i % 2 == 0)
                {
                    
                    sum =sum + i;
                   //Console.WriteLine("Even no is  " + i);
                }
            }
            Console.WriteLine("sum of all even no = " +sum);
            Console.ReadLine();
        }
    }
}
