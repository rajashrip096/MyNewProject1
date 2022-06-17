using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyNewProject1.BranchingStatement
{
    class TernaryPositiveNegative
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter the number");
            int num = int.Parse(Console.ReadLine());

            string temp = num > 0 ? "number is positive" : (num < 0)? "number is negative":"number is zero";
            Console.WriteLine(temp);
            Console.ReadLine();
            /*if(num>0)
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
            }*/
        }
    }
}
