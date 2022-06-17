using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyNewProject1.LoopDemo
{
    //write the code for spy number.
    class SpyNo
    {
        static void Main(string[] args)
        {
            int sum = 0;
            int product = 1;
            
            Console.WriteLine("Enter the number");
            int num = int.Parse(Console.ReadLine());
            while(num>0)
            {
                int r = num % 10;
                sum = sum + r;
                product = product * r;
                num = num / 10;
            }
            //Console.WriteLine(sum);

            if (sum == product)
            {
               Console.WriteLine("Number is spy");
               Console.ReadLine();
            }
            else
            {
                 Console.WriteLine("Number is not spy");
                 Console.ReadLine();
            }

            
        }
    }
}
