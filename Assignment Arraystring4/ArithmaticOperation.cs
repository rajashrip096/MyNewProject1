using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyNewProject1.Assignment_Arraystring4
{
    //Write a  program to enter two numbers and
    //perform all arithmetic operations Different Program for each .
    class ArithmaticOperation
    {
        static void Main(string[] args)
        {
            int[] a = new int[10];
            Console.WriteLine("Enter the no");
            int x = int.Parse(Console.ReadLine());
            int y = int.Parse(Console.ReadLine());

            Console.WriteLine("Addition is ="+(x+y));
            Console.WriteLine("Substration is = "+(x-y));
            Console.WriteLine("Multiplication is = "+(x*y));
            Console.WriteLine("Division is = "+(x/y));
            Console.ReadLine();

        }
    }
}
