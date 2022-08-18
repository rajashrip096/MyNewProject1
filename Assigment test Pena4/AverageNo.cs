using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyNewProject1.Assigment_test_Pena4
{
    class AverageNo
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter the three no");
            int a = int.Parse(Console.ReadLine());
            int b = int.Parse(Console.ReadLine());
            int c = int.Parse(Console.ReadLine());
            int avg = 0;
            int sum = 0;

            sum = (a + b + c);
            avg = sum / 3;
            Console.WriteLine("Average of three no is : " + avg);
            Console.ReadLine();
        }
    }
}
