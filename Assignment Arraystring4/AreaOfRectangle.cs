using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyNewProject1.Assignment_Arraystring4
{
    class AreaOfRectangle
    {
     //Write a  program to enter length and breadth of a rectangle and find its Area
        static void Main(string[] args)
        {
            int[] a = new int[5];
            double Area;
            double length, breath;
            Console.WriteLine("Enter the first number");
            length = Convert.ToInt32(Console.ReadLine());
            breath = Convert.ToInt32(Console.ReadLine());
            
                Area = length * breath;

                Console.WriteLine("Area of Rectangle = "+Area);
            Console.ReadLine();


        }
    }
}
