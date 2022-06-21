using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyNewProject1.Assignment_Array_3
{
    class DuplicateArrayRemove
    {
        static void Main(string[] args)
        {
            int[] a = { 1, 1, 2, 8, 6, 8, 7, 0 };
            int count = 0;
            bool isVisited = false;
            for(int i=0;i<a.Length;i++)
            {
                for (int j = 0; j < a.Length; j++)
                {
                    if(a[i]==a[j])
                    {
                        isVisited = true;
                        break;
                    }
                }
                if(isVisited = true)
                {
                    for (int j = 0; j < a.Length; i++)
                    {
                        if (a[i] == a[j])
                        {
                            count++;
                        }
                        if (count == 1)
                        {
                            Console.WriteLine(count);
                            Console.ReadLine();
                        }
                    }
                }
            }
        }
    }
}
