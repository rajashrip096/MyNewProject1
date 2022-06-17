using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyNewProject1.BranchingStatement
{
    class OddEvenSwitchCase
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter the value");
            int num = Convert.ToInt32(Console.ReadLine());


            switch (num % 2)
            {
                case 0:
                    Console.WriteLine(num +  "number is Even");
                    Console.ReadLine();
                    break;
                case 1:
                    Console.WriteLine(num +  "number is Odd");
                    Console.ReadLine();
                    break;
            }
            Console.ReadLine();
        }
    }
}
