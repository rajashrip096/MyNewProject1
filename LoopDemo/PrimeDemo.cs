using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyNewProject1.LoopDemo
{
    class PrimeDemo
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter the number");
            int num = int.Parse(Console.ReadLine());

            bool isprime = true;
            for(int i=2;i<num;i++)
            {
                if (num % i == 0)
                {
                    isprime = false;
                }
            }
        
            if (isprime == true)
            {
                Console.WriteLine("Prime");
                Console.ReadLine();
            }
            else
            {
                Console.WriteLine("not Prime");
                Console.ReadLine();
            }
        }      

    }
}
