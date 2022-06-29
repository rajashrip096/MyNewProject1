using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyNewProject1.Assignment_Arraystring4
{
    class UniqueElement
    {
        //1.	WAP to print all unique elements in the array
        static void Main(string[] args)
        {
            int[] a = { 1, 3, 9, 2, 1, 3 };
            Console.WriteLine(string.Join(" ",a));
            for(int i=0;i<a.Length;i++)
            {
                bool isVisited = false;
                int count = 1;
                for(int k=i-1;k>=0;k--)
                {
                    if(a[i]==a[k])
                    {
                        isVisited = true;
                        break;
                    }
                }
                if(isVisited==false)
                {
                    for(int j=i+1;j<a.Length;j++)
                    {
                        if(a[j]== a[i])
                        {
                            count++;
                        }
                    }
                    if (count == 1)
                    {
                        Console.WriteLine(a[i] + " " + count);
                        Console.ReadLine();
                    }
                }
               
            }
        }
    }
}
