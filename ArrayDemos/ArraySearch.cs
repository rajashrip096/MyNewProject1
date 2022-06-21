using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyNewProject1.ArrayDemos
{
    class ArraySearch
    {
        static void Main(string[] args)
        {
            int[] a = { 5, 7, 1, 9 };
            Console.WriteLine("Enter element for search");
            int num = int.Parse(Console.ReadLine());
            bool isPresent = false;
            for(int i=0;i<a.Length;i++)
            {
                if(a[i]==num)
                {
                    isPresent = true;
                    break;
                }
            }
            if(isPresent==true)
            {
                Console.WriteLine("Element is Present");
                Console.ReadLine();
            }
            else
            {
                Console.WriteLine("Not Present");
                Console.ReadLine();
            }
           
        }
    }
}
