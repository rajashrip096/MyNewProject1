using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyNewProject1.BranchingStatement
{
    class TenaryAbsoluteProgram
    {
        static void Main(string[] args)
        {
            
            Console.WriteLine("Enter the number");
            int num = Convert.ToInt32(Console.ReadLine());

            int temp = (num >= 0)? num:-num;
            Console.WriteLine(temp);
            Console.ReadLine();
        }
    }
}
