using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyNewProject1.Assignment_for_Loop
{
    //WAP to print number from 1 to 50 if number is even then print as
    //it is and number is odd then print negative number with its square
    class EvenandOddsquarecs
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter the number");
            int num = int.Parse(Console.ReadLine());
            
            for(int i=1;i<50;i++)
            {
                if (i % 2 == 0)
                {
                    Console.WriteLine("Even = "+i);
                }
                else if (i % 2 != 0)
                {

                    Console.WriteLine("Odd = " +(-(i*i)));
                }
                else
                {
                    Console.WriteLine();
                }
            }
            
            Console.ReadLine();
        }
    }
}
