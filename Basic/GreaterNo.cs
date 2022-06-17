using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyNewProject1.Basic
{
    class GreaterNo
    {
        static void Main(string[] args)
        {
            int num1, num2;
            num1 = 20;
            num2 = 10;
            if (num1>num2)
            {
                Console.WriteLine("Number is greater");
                Console.ReadLine();
            }
            else
            {
                Console.WriteLine("Number is not greater");
                Console.ReadLine();
            }
        }
    }
}
