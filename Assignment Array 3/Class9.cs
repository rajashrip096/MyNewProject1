using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyNewProject1.Assignment_Array_3
{
    class Class9
    {
        public static void Main(String[] args)
        {
            int[] var = new int[10];
            for (int i = 0; i < 10; ++i)
            {
                var[i] = i;
                Console.WriteLine(var[i] +" ");
                i++;
            }
            Console.ReadLine();         ////output :  0 2 4 6 8
        }
    }
}
   

