using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyNewProject1.BranchingStatement
{
    class TernaryOddEven
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter the number");
            int n = int.Parse(Console.ReadLine());

            string result = (n % 2 == 0) ? "number is Even" : "number is Odd";
            Console.WriteLine(result);
            Console.ReadLine();
        }
    }
}
