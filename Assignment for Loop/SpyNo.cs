using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyNewProject1.Assignment_for_Loop
{
    //write a  program to check given number is spy number or not
    //e.g 123 if sum of digit is equals to product of digit the number is spy number
    //i.e 123=1+2+3=6 and 1*2*3=6 so the number is spy  number

    class SpyNo
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter the number");
            int num=Convert.ToInt32(Console.ReadLine());
            int sum = 0;
            int product = 1;
            while(num>0)
            {
                int r = num % 10;
                sum = sum + r;
                product = product * r;
                num = num / 10;
            }
            if(sum==product)
            {
                Console.WriteLine("Number is spy");
            }
            else
            {
                Console.WriteLine("Number is not spy");
            }
            Console.ReadLine();
        }
    }
}
