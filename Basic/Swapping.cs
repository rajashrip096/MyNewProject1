using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyNewProject1.Basic
{
    class Swapping
    {
        static void Main(string[] args)
        {
            int num1, num2, temp;
            num1 = 29;
            num2 = 50;
            temp = num1;
            num1 = num2;
            num2 = temp;
            Console.WriteLine(num1 + " " + num2);
            Console.ReadLine();
        }
    }
}
