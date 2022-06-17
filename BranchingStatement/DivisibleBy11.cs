using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyNewProject1.BranchingStatement
{
    class DivisibleBy11
    {
        static void Main(string[] args)
        {
           // int n;
            Console.WriteLine("Enter the no");
            int n = Convert.ToInt32(Console.ReadLine());
            Console.ReadLine();
            if(n % 11==0)
            {
                Console.WriteLine("Number is divisible by 11");
                Console.ReadLine();
            }
            else
            {
                Console.WriteLine("Number is not divisible by 11");
                Console.ReadLine();
            }
        }

    }
}
