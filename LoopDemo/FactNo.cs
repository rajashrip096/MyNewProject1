using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyNewProject1.LoopDemo
{
    class FactNo
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter the no ");
            int n = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine( "Factorial is "+n);

            for (int i = 1; i <= n; i++)
            {
                if(n % i== 0)
                {
                    Console.WriteLine(i);
                    Console.ReadLine();
                }
            }
            
        }
    }
}
