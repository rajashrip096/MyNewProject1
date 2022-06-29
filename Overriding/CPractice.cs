using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyNewProject1.Overriding
{
    class CPractice
    {
        //int x = 10;
        //static int y = 20;
        static void Main(string[] args)
        {
            // int x = 100;
            // int y = 200;
            // Console.WriteLine(x);
            //Console.WriteLine(y);
            // Console.WriteLine(CPractice.y);
            /*int[][] a = new int[2][];
            a[0] = new int[4] { 6, 1, 4, 3 };
            a[1] = new int[3] { 9, 2, 7 };
            Console.WriteLine(a[1].GetUpperBound(0));*/
            int i = 0, j = 0;
        label:
            i++;
            j += i;
            if(i<10)
            {
                Console.WriteLine(i+" ");
                goto label;
            }

            Console.ReadLine();
              
        }
    }
}
