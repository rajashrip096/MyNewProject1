using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyNewProject1.Practiceinterview
{
    class Fibboseries1
    {
        static void Main(string[] args)
        {
            int a = 0, b = 1, c;
            for(int i=0;i<10;i++)
            {
                c = a + b;
                Console.WriteLine(a);
                a = b;
                b = c;
            }
            Console.ReadLine();
        }
    }
}
