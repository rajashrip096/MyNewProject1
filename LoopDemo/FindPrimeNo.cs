using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyNewProject1.LoopDemo
{
    class FindPrimeNo
    {
        static void Main(string[] args)
        {
            int i, n1,n2,n, count=0;
            Console.WriteLine("Enter starting range ");
             n1 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter ending range ");
            n2 = Convert.ToInt32(Console.ReadLine());

            
            for (i = n1; i <= n2; i++)
            {
                count = 0;
                for (n = 0; n < i/2; n++)
                {
                    if (i % n == 0)
                    {
                        count=1;
                        break;
                    }
                }

                if (count !=1)
                {
                    Console.WriteLine(i);
                    Console.ReadLine();
                }
            }
                     //Console.WriteLine(i);
                     //Console.ReadLine();
        }
    }
}
