using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyNewProject1.ConditinalDemo
{
    class GreaterThreeNo
    {
        static void Main(string[] args)
        {
            int num1, num2, num3;
            Console.WriteLine("Enter the 1st  Number");
             num1 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter the 2nd Number");
             num2 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter the 3rd Number");
             num3 = Convert.ToInt32(Console.ReadLine());

            if (num1 > num2)
            {

                if (num1 > num3)
                {
                    Console.WriteLine(num1 + " is greater no");
                    Console.ReadLine();
                }
                else
                {
                    Console.WriteLine(num3 + " is greater no");
                    Console.ReadLine();
                }
            }

            else if (num2 > num3)
            {
                Console.WriteLine(num2 + " is greater no");
                Console.ReadLine();
            }
            else
            {
                Console.WriteLine(num3 + " is greater no");
                Console.ReadLine();
            }

        } 
            
            
        
    }
}
