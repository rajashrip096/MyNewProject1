using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyNewProject1.Assignment_Arraystring4
{
    class AreaOfTriangle
    {
        //Write a program to enter base and height of a triangle and find its area
        static void Main(string[] args)
        {
            int[] a = new int[5];
            double base1, height, Area;
            Console.WriteLine("Enter the no");
            base1 = Convert.ToInt32(Console.ReadLine());
            height = Convert.ToInt32(Console.ReadLine());
            Area = (base1 * height)/2;
            Console.WriteLine("Area of Triangle ="+Area);
            Console.ReadLine();





        }
    }
}
