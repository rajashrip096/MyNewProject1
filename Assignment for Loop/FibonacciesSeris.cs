using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyNewProject1.Assignment_for_Loop
{
    //WAP to print fibbo series upto 20 terms
    class FibonacciesSeris
    {
        static void Main(string[] args)
        {
            int a = 0, b = 1, n = 20, c;
            for(int i=1;i<=20;i++)
            {
                c = a + b;
                Console.WriteLine(a);
                a = b;
                b = c;
            }
            Console.ReadLine();
        }
    }
}
