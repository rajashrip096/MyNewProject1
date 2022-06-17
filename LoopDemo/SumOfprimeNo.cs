using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyNewProject1.LoopDemo
{
    //write the code sum of all prime number.
    class SumOfprimeNo
    {

        static void Main(string[] args)
        {
            int  p,k;
             int sum = 0;
            Console.WriteLine("Enter the number");
             int n = Convert.ToInt32(Console.ReadLine());

            for (int i = 2; i <= 10; i++)
            {
                k = 2;
                p = 1;
                while (k < i)
                {
                    if (i % k == 0)
                    {
                        p = 0;
                        break;
                    }
                    k++;
                }
                if (p == 1)
                {
                    sum = sum + i;
                }
            }
            Console.WriteLine("Sum of prime no is = " +sum);
            Console.ReadLine();
        }   
    }
}
