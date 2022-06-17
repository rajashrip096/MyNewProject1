using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyNewProject1.Assignment_for_Loop
{
    class Countno
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter the number");
            int n=int.Parse(Console.ReadLine());
            int count = 0;
            for(int i=0;i<n;i++)
            {
                
                n = n % 10;
                count++;
            }
            Console.WriteLine(n);
            Console.ReadLine();
        }
    }
}
