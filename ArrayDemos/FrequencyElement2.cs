using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyNewProject1.ArrayDemos
{
    class FrequencyElement2
    {
        static void Main(string[] args)
        {
            //frequency of each element
            int[] a = { 4, 1, 3, 1, 5, 1, 4 };
            for(int i=0;i<a.Length;i++)
            {
                int count = 1;
                bool isVisited = false;
                for(int k=i-1;k>=0;k--)
                {
                    if(a[i]==a[k])
                    {
                        isVisited = true;
                        break;
                    }
                }
                if (isVisited == false)
                {
                    for(int j=i+1;j<a.Length;j++)
                    {
                        if(a[i]==a[j])
                        {
                            count++;
                        }
                    }
                    /* if (count == 1)
                     {
                         Console.WriteLine(a[i] + "  " + count);
                     }*/

                   
                   /* if (count > 1)
                    {
                        Console.WriteLine(a[i] + "  " + count);
                    }*/
                    Console.WriteLine(a[i] + "  " + count);
                }
            }
            Console.ReadLine();

        }
    }
}
