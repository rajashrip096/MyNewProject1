using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyNewProject1.ConditinalDemo
{
    class DivisibleByFive
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter the number");
            int n = int.Parse(Console.ReadLine());

            if (n % 5 == 0)
            {
                Console.WriteLine("Number is divisible");
                Console.ReadLine();
            }
            else
            {
                Console.WriteLine("Number is not divisible");
                Console.ReadLine();
            }
        }
    }
}
