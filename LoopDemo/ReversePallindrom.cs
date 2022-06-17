 using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyNewProject1.LoopDemo
{
    //write the code for palindrom number
    class ReversePallindrom
    {
        static void Main(string[] args)
        {
            int n, r, rev = 0, temp;
            Console.WriteLine("enter the number");
            n = Convert.ToInt32(Console.ReadLine());

            temp = n;
            do
            {
                r = n % 10;
                rev = (rev * 10) + r;
                n = n / 10;
            }
            while (n != 0);
            {
                if (rev == temp)
                {
                    Console.WriteLine("Number is Pallindrom");
                    Console.ReadLine();
                }
                else
                {
                    Console.WriteLine("Number is not Pallindrom");
                    Console.ReadLine();
                }

            }
        }
    }
}
