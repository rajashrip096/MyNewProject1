using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyNewProject1.Oops
{
    class CalculateArithmtic
    {
        void calculate(int x,int y)
        {
            Console.WriteLine("Addition is = "+(x+y));
            Console.ReadLine();
        }
        void calculate(double a,double b)
        {
            Console.WriteLine("Substraction is " +(a-b));
            Console.ReadLine();
        }
        void calculate()
        {
            int a = 10;
            int b = 2;
            Console.WriteLine("Division is "+(a/b));
            Console.ReadLine();
        }
        void calculate(double a ,float b)
        {
            Console.WriteLine("multiplication is "+(a*b));
            Console.ReadLine();
        }
        static void Main(string[] args)
        {
            CalculateArithmtic m1 = new CalculateArithmtic();
            m1.calculate(2,4);
            m1.calculate(12.1, 10.0);
            m1.calculate();
            m1.calculate(4, 3.2f);
        }
        
    }
}
