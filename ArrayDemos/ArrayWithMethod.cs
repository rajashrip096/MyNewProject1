using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyNewProject1.ArrayDemos
{
    class ArrayWithMethod
    {
        //public int  SumOfEven(int []arr)
        public void SumOfEven(int[] arr)
        {
            Console.WriteLine(arr.GetHashCode());
            int sum = 0;
            for(int i=0;i<arr.Length;i++)
            {
                if(arr[i]%2==0)
                {
                    sum = sum + arr[i];
                }
            }
           Console.WriteLine("Sum of even =" +sum);
            //return sum;
        }
        static void Main(string[] args)
        {
            int[] a = { 8, 3, 5, 1, 2, 6 };
            ArrayWithMethod m = new ArrayWithMethod();
            m.SumOfEven(a);
            //int sum = m.SumOfEven(a);
            Console.WriteLine(a.GetHashCode());
            //Console.WriteLine(sum);
            Console.ReadLine();
        }
    }
}
