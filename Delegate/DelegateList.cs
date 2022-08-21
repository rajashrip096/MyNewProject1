using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyNewProject1.Delegate
{
    class DelegateList
    {
        static void greet()
        {
            Console.WriteLine("Happy Morning");
            //return 90;
        }
        static void m2(int a, int b, Action d1)
        {
            Console.WriteLine("Addition : " + (a + b));
            d1();
        }
        static bool isEven(int n)
        {
            Console.WriteLine("Even :" + n);
            return n % 2 == 0;
        }
        static void print(int a)
        {
            Console.WriteLine(a);
        }

        static void Main(string[] args)
        {
            m2(10, 20, () => Console.WriteLine("Happy Evening"));
            List<int> lst = new List<int>() { 11, 45, 28, 66, 34, 99, 13, 14 };
            List<int> l3 = lst.FindAll(a => a % 2 == 0);

            //print all
            //lst.ForEach(print);
            //or
            lst.ForEach(d => Console.WriteLine(d));

            /*foreach(int d in l3)
                Console.WriteLine(d);*/

            //List<int> l2 = new List<int>();

            /* foreach(int d in lst)
             {
                 if(d%2==0)
                 {
                     l2.Add(d);
                 }
             }*/
            Console.ReadLine();
        }
    }
}
