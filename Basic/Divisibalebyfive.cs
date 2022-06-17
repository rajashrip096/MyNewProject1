using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyNewProject1.Basic
{
    class Divisibalebyfive
    {
        static void Main(string[] args)
        {
            int n;
            n = 30;
            if(n%5==0)
            {
                Console.WriteLine("Number is Divisible");
                Console.ReadLine();
            }
            else
            {
                Console.WriteLine("Number is Not Divisible");
                Console.ReadLine();
            }
        }
    }
}
