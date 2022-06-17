using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyNewProject1.ConditinalDemo
{
    class OddEven
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter the 1st number");
            int n = int.Parse(Console.ReadLine());

            if (n % 2 == 0)
            {
                Console.WriteLine("number is Even");
                Console.ReadLine();
            }
            else 
            {
                Console.WriteLine("number is Odd");
                Console.ReadLine();
            }
        }
    }
}
