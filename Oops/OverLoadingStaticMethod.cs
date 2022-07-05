using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyNewProject1.Oops
{
    //write a code to shopw overloading of static method
    class OverLoadingStaticMethod
    {
        static void show()
        {
            Console.WriteLine("Hello");
            Console.ReadLine();
        }
        void get()
        {
            Console.WriteLine("dot net");
            Console.ReadLine();
        }
        static void Main(string[] args)
        {
           OverLoadingStaticMethod m2 = new OverLoadingStaticMethod();
            m2.get();
           // OverLoadingStaticMethod.show();

        }
    }
}
