using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyNewProject1.Assignment_Arraystring4
{
    //.Write a Program to calculate Square of given number
    class Squarearray
    {
        static void Main(string[] args)
        {
            int[] a = new int[5];
            Console.WriteLine("Enter the no");
            double n = double.Parse(Console.ReadLine());
            double square = n * n;
            Console.WriteLine("square is ="+square);
            Console.ReadLine();
        }
    }
}
