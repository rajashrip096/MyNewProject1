using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyNewProject1.ThreadDemo
{
    class CoPrime
    {
        static void Main(string[] args)
        {
            int n1 = int.Parse(Console.ReadLine());
            int n2 = int.Parse(Console.ReadLine());
            int gcd = 1;
            for (int i = 1; i <= n1; i++)
            {
                if (n1 % i == 0 && n2 % 2 == 0)
                {
                    gcd = i;
                }
            }
            if (gcd == 1)
            {
                Console.WriteLine("Co-Prime");
            }
            else
            {
                Console.WriteLine("Not Coprime");
            }
            Console.ReadLine();
        }
    }
}
