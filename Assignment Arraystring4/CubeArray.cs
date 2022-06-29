using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyNewProject1.Assignment_Arraystring4
{
    //Write a Program to calculate cube of given number
    class CubeArray
    {
        static void Main(string[] args)
        {
            int[] a = new int[5];
            Console.WriteLine("Enter the no");
            int n = int.Parse(Console.ReadLine());
            int cube = n * n * n;
            Console.WriteLine("cube is = "+cube);
            Console.ReadLine();
        }
    }
}
