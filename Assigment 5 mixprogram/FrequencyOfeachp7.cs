using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyNewProject1.Assigment_5_mixprogram
{
    class FrequencyOfeachp7
    {
        //7.WAP to find out frequency of each digit in given mobile number using only single loop. 
        static void Main(string[] args)
        {
            Console.WriteLine("Enter the mobile no");
            int  n = int.Parse(Console.ReadLine());
            int count=0;
            int n1;
            //int freq;
           
            for(int i=0;i<=n;i++)
            {
                
            }
            while(n!=0)
            {
                int lastdigit = n % 10;
                n = n / 10;
            }
            Console.WriteLine("Frequency of each digit :"+count);
            Console.ReadLine();
        }
    }
}
