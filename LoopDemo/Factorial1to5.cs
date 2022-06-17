using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyNewProject1.LoopDemo
{
    class Factorial1to5
    {
        static void Main(string[] args)
        {
            int fact = 1;
            int sum = 0;
            Console.WriteLine("Enter the no: ");
            int n = Convert.ToInt32(Console.ReadLine());

            for (int i = 1; i <= 5; i++)
            {
                fact = fact * i;
                sum += fact;

            }
            Console.WriteLine(sum);
            Console.ReadLine();
        }
    }
}
