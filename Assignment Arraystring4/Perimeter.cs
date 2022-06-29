using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyNewProject1.Assignment_Arraystring4
{
    //Write a Java program to enter length and breadth of a rectangle and
    //find its perimeter.
    class Perimeter
    {
        static void Main(string[] args)
        {
            int[] a = new int[5];
            double length, width, perimeter;
            Console.WriteLine("Enter the length & width of rectangle");
            length = Convert.ToDouble(Console.ReadLine());
            width = Convert.ToDouble(Console.ReadLine());
            perimeter = 2 * (length + width);
            Console.WriteLine("Perimeter of Rectangle is = "+perimeter);
            Console.ReadLine();
        }
    }
}
