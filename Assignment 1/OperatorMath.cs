using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyNewProject1.Assignment_1
{
    class OperatorMath
    {
        static void Main(string[] args)
        {
            /*int a = 5; b= 4; c = 3;
            Console.WriteLine(a++ +b* ++c);
            Console.WriteLine("a="+a+"b="+b+"c="+c);
            Console.WriteLine(b*5/a+b++ +b);
            Console.WriteLine("a="+a+"b="+b+"c="+c);*/
            // Console.WriteLine("Enter the no");
            //int n = Convert.ToInt32(Console.ReadLine());
            //Console.ReadLine();
            /*if ((n % 5 == 0) && (n % 11 == 0))

            {
                Console.WriteLine("Number is divisible by 5 & 11");
                Console.ReadLine();
            }
            else
            {
                Console.WriteLine("Number is not divisible by 5 & 11");
                Console.ReadLine();
            }*/

            Console.WriteLine("Enter the no");
            int num1 = Convert.ToInt32(Console.ReadLine());
            int num2 = Convert.ToInt32(Console.ReadLine());
            int num3 = Convert.ToInt32(Console.ReadLine());
            int max = 0;
            if ((num1 >= num2) && (num1 >= num3))
            {
                max = num1;
                
            }
            else if ((num2 >= num3) && (num2 >= num1))
            {
                max = num2;
                
            }
            else if((num3>=num1) && (num3>=num2))
            {
                max = num3;
                
            }
            Console.WriteLine("Maximun number is  "+max);
            Console.ReadLine();

        }
    }
}
