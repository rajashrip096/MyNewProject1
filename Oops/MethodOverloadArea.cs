using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyNewProject1.Oops
{
    //Write the code overload area method cal;culate method area od circle ,area of triangle,area ofrectangle,& square
    class MethodOverloadArea
    {
        void area(double r )
        {
            Console.WriteLine("Area of Circle is "+(3.14*r*r));
            Console.ReadLine();
        }
        void area(int length,int breath)
        {
            Console.WriteLine("Area of Rectangle "+(length*breath));
            Console.ReadLine();
        }
        void area(double b,double h)
        {
            Console.WriteLine("Area of tringle "+(0.5*b*h));
            Console.ReadLine();
        }
        void area(int a)
        {
            Console.WriteLine("Area of square "+(a*a));
            Console.ReadLine();
        }
        static void Main(string[] args)
        {
            MethodOverloadArea m = new MethodOverloadArea();
            m.area(4.0, 4.0);
            m.area(2, 3);
            m.area(10.0, 2);
            m.area(2.6);
         
        }
    }
}
