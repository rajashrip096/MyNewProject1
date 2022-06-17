using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyNewProject1.LoopDemo
{
    class KaprekarNo
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter the no");
            int num = Convert.ToInt32(Console.ReadLine());
            int temp = num;
            int sq = num * num;
            int count = 0;
            
            while(num>0)
            {
                count++;
                num = num / 10;
            }
            int power = 1;
            for(int i=1;i<=count;i++)
            {
                power = power * 10;
            }
            int division = sq / power;
            int remainder = sq % power;

            int sum = division + remainder;
            if (sum == temp)
            {
                Console.WriteLine("Number is kaprekar");
            }
            else
            {
                Console.WriteLine("Number is Not kaprekar");
            }
            Console.ReadLine();

        }
    }
}
