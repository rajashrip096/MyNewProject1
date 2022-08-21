using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyNewProject1.Delegate
{
    public delegate int mydel7(int n);
    class FactorialDeleagte
    {
        static void Main(string[] args)
        {
            mydel7 dd = (n) =>
            {
                int fact = 1;
                for (int i = 1; i <= n; i++)
                {
                    fact = fact * i;

                }
                return fact;
            };
            int a = dd(4);
            Console.WriteLine("Factorial is :" + a);
            Console.ReadLine();
        }
    }
}
