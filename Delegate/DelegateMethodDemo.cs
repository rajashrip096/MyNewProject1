using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyNewProject1.Delegate
{
    class DelegateMethodDemo
    {
        static double m1(int r, char c)
        {
            return r * 3.4;
        }
        static void m2(byte a, string e)
        {
            Console.WriteLine("in m2" + e + a);
        }
        static bool m3(long m)
        {
            return true;
        }
        static void Main(string[] args)
        {
            Func<int, char, double> f1 = m1;
            double d1 = f1(4, 'a');
            Action<byte, string> a1 = m2;
            a1(10, "Riya");
            Func<long, bool> ff = m3;
            bool b1 = ff(2333);

            //Predicate <long> p1 = m3;
            // p1(36125);
            Console.ReadLine();

        }
    }
}
