using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyNewProject1.LoopDemo
{
    class FibonacciSeries
    {
        static void Main(string[] args)
        {
            int a=0, b=1, n=10, c;
            
            for (int i = 1; i <= n; i++)
            {
                c = a + b;
                Console.WriteLine(a);
                Console.ReadLine();
                a = b;
                b = c;
            }
            


        }
    }
}
