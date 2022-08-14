using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyNewProject1.LoopDemo
{
        //write the code to print power of given no
    class Power
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter the base");


            int base1 = int.Parse(Console.ReadLine());
            Console.WriteLine("Enter the exponenent");
            int expo = int.Parse(Console.ReadLine());
            int power = 1;
            for(int i=1;i<=expo;i++)
            {
                power = power * base1;
            }
            Console.WriteLine(power);
            Console.ReadLine();
        }
    }
    class Coprime
    {
        static int gcd(int a, int b)
        {
            if (a == 0 || b == 0)
            {
                return 0;
            }
            if (a == b)
            {
                return a;
            }
            if (a > b)
            {
                return gcd(a - b, b);
            }
            else
            {
                return gcd(a, b - a);
            }
        }
            static void coprime(int a,int b)
            {
                if(gcd(a,b)==1)
                {
                    Console.WriteLine("Co-prime");
                }
                else
                {
                    Console.WriteLine("not co-prime");
                }
            }
        
        static void Main(string[] args)
        {
            coprime(5, 6);


        }
    }
}
