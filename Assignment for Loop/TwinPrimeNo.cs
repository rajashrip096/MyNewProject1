using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyNewProject1.Assignment_for_Loop
{
    //) Write a program to find twin prime number. (Accept two no from
    //user and check, if both are prime and their difference is 2 then they
    //are twin prime).
    class TwinPrimeNo
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter the number");
            int num = int.Parse(Console.ReadLine());
            bool isprime = true;
            for(int i=2;i<num;i++)
            {
                if (num % i == 0 && num%(i+2)==0)
                {
                    isprime = false;
                }
            }
            if(isprime==true)
            {
                Console.WriteLine("Prime number");
            }
            else
            {
                Console.WriteLine("Not prime number");
            }
            Console.ReadLine();
        }
    }
}
