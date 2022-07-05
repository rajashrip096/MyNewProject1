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
            int i, n1, count=0;
            Console.WriteLine("Enter the no ");
             n1 = Convert.ToInt32(Console.ReadLine());
            
            for (i = 2; i < n1; i++)
            {
                
                    if (n1%i == 0)
                    {
                        count++;
                        break;
                    }
            }

                if (count ==0)
                {
                    Console.WriteLine("number is prime");
                    
                }
                else
                {
                    Console.WriteLine("number is not prime");
                }
                     Console.ReadLine();
        }
    }
}
