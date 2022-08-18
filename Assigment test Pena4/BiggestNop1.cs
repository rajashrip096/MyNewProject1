using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyNewProject1.Assigment_test_Pena4
{
    //Write a C# Program to Find biggest of three numbers using if else Statement
    class BiggestNop1
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter the three no");
            int num1 = int.Parse(Console.ReadLine());
            int num2 = int.Parse(Console.ReadLine());
            int num3 = int.Parse(Console.ReadLine());

            if (num1 > num2 && num1 > num3)
            {
                Console.WriteLine(num1 + " is Biggest no");
            }
            else if (num2 > num1 && num2 > num3)
            {
                Console.WriteLine(num2 + " is Biggest no");
            }
            else
            {
                Console.WriteLine(num3 + " is Biggest no");
            }
            Console.ReadLine();
        }
    }
}
