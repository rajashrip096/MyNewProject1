using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyNewProject1.Assignment_Array_3
{
    //create a Array of integer and count the number of even  and odd elements from array.
    class EvenOddCount
    {
        static void Main(string[] args)
        {
            int[] a = { 10, 2, 3, 7, 28, 91, 76, 66, 90, 11, 13 };
            int even = 0;
            int odd = 0;
            
            for(int i=0;i<a.Length;i++)
            {
                if (i%2==0)
                {
                    even++;
                }
                else
                {
                    odd++;
                }
            }
            Console.WriteLine("Total Even no  is = " + even);
            Console.WriteLine("Total odd no  is = " + odd);
            Console.ReadLine();
        }
    }
}
