using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyNewProject1.Delegate
{
    public delegate void mydel1(int a, int b);
    public delegate int mydel2(int a);
    class AnamonymousFunAndLambdaFun
    {
        //public static void factorial(int n)
        static void Main(string[] args)
        {
            //Anonymous function
            mydel1 d = delegate (int a, int b)
            {
                Console.WriteLine("Product = " + (a * b));
            };
            d(9, 7);

            //Lambda function
            mydel1 d2 = (a, b) => Console.WriteLine("Area of rectangle =" + (a * b));
            d2(11, 12);

            mydel2 ddd = (a) =>
            {
                return a * a;
            };
            int sq = ddd(6);

            mydel2 ddd2 = (a) => a * a;
            int sqq = ddd2(9);
            Console.WriteLine("Square =" + sqq);
            Console.ReadLine();
        }
    }
}
