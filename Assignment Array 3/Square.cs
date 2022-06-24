using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyNewProject1.Assignment_Array_3
{
    class Square
    {
        static void Main(string[] args)
        {
            int[] a = { 23, 43, 25, 49, 12, 9, 78, 66, 39, 0 };
           
            foreach(int m in a)
            {
                for (int i = 1; i < m; i++)
                {
                    if (i * i==m)
                    {
                        Console.WriteLine(m);
                        Console.ReadLine();
                    }
                }


            }
        }
    }




}
