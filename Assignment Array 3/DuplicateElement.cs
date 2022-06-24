using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyNewProject1.Assignment_Array_3
{
    class DuplicateElement
    {
        static void Main(string[] args)
        {
            int[] a = { 4, 3, 2, 1, 4 };
            int[] b = { 4, 3, 2, 9 };
           
            int[] c = new int[a.Length + b.Length];
            
            for (int i = 0; i <=a.Length; i++)
            {
                int count = 0;
                bool ispresent = false;
                for(int k=i-1;k>=0;k--)
                {
                    if(a[k]==a[i])
                    {
                        ispresent = true;
                        break;
                    }
                }
                if (ispresent == false)
                {
                    for (int j = i + 1; j < a.Length; j++)
                    {
                        if (c[j] == a[i])
                        {
                            count++;
                        }
                    }
                    if(count==1)
                    {
                        Console.WriteLine(count);
                    }
                }
                
            }
            Console.WriteLine(string.Join(" ", a));
            Console.WriteLine(string.Join(" ", b));
            Console.WriteLine(string.Join(" ",c));
            Console.ReadLine();
           
        }
    }
}
