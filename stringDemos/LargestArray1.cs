using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyNewProject1.stringDemos
{
    class LargestArray1
    {
        public int largestSubarray(int input1,int[] input2)
        {
            
            for (int i = 0; i < input1; i++)
            {
                input2[i] = int.Parse(Console.ReadLine());
            }
            int max = 0;
            int zeros, ones = 0;
            for(int i=0;i<input2.Length;i++)
            {
                zeros = 0;
                    ones = 0;
                for(int j=i;j<input2.Length;j++)
                {

                    if (input2[j] == 0)
                    {
                        zeros++;
                    }
                    else
                    {
                        ones++;
                    }

                    if (zeros == ones)
                    {
                        max = max > (j - i + 1) ? max : j - i + 1;
                        
                    }
                    
                    //Console.ReadLine();
                }
               
            }
            Console.WriteLine(max);
            return max;
        }
        static void Main(string[] args)
        {
            int size = int.Parse(Console.ReadLine());
            int[] input2 = new int[size];
            LargestArray1 l = new LargestArray1();
            int input1 = input2.Length;
            int max=l.largestSubarray(input1,input2);
           //Console.WriteLine(max);
            Console.ReadLine();
            
        }
    }
}
