using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyNewProject1.Assignment_1
{
    class AreaEquilateralTriangle
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter the no");
            double a=Convert.ToDouble(Console.ReadLine());
            double Area;

            Area = (1.732 / 4) * a * a;
            Console.WriteLine("Area of Equilateral Triangle is " +Area);
            Console.ReadLine();

        }
    }
}
