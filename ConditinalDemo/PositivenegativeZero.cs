using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyNewProject1.ConditinalDemo
{
    class PositivenegativeZero
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter the Number");
            int num = int.Parse(Console.ReadLine());
            if (num > 0)
            {
                Console.WriteLine("Number is positive");
                Console.ReadLine();
            }
            else if (num < 0)
            {
                Console.WriteLine("Number is Negative");
                Console.ReadLine();
            }
            else 
            {
                Console.WriteLine("Number is Zero");
                Console.ReadLine();
            }
        }
    }
}
