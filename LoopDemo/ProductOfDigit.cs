using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyNewProject1.LoopDemo
{
    //write the code for producty of the digit
    class ProductOfDigit
    {
        static void Main(string[] args)
        {
            int n, product = 1;
            Console.WriteLine("Enter any number");
            n = Convert.ToInt32(Console.ReadLine());
            while(n !=0)
            {
               
                product = product * (n % 10);
                n = n / 10;

            }
            Console.WriteLine("Product of Digit is " +product);
            Console.ReadLine();
        }
    }
}
