using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyNewProject1.Assigment_test_Pena4
{
    // //Write a C# Program to enter two float input values and Multiply print roundup by 2 digit after decimal
    class Program3Roundby
    {
        static void Main(string[] args)
        {
            float a = 8.675f;
            float b = 4.2456f;
            float c = a + b;
            Console.WriteLine(Math.Round(c, 2));
            Console.ReadLine();
        }
    }
}
