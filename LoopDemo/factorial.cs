using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyNewProject1.LoopDemo
{
    class factorial
    {
        static void Main(string[] args)
        {
          int i, n, fact = 1;
             
            Console.WriteLine("Enter tthe no ");
             n = Convert.ToInt32(Console.ReadLine());

           for(i=1;i<=n;i++)
            {
                fact = fact * i;

               // sum += fact;
            }
            Console.WriteLine("factorial is "+fact);
            Console.ReadLine();

        }

    }
}
