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
            long  n = long.Parse(Console.ReadLine());
            string num = n.ToString();
            char[] a = num.ToCharArray();
            for(int i=0;i<a.Length;i++)
            {
                int count = 1;
                bool isvisited = false;
                for(int k=i-1;k>=0;k--)
                {
                    if(a[i]==a[k])
                    {
                        isvisited = true;
                        break;
                    }
                }
                if(isvisited==false)
                {
                    for(int j=i+1;j<a.Length;j++)
                    {
                        if(a[i]==a[j])
                        {
                            count++;
                        }
                    }
                    Console.WriteLine("Digit is : "+a[i] + "  count : "+count);
                }
            }
            Console.ReadLine();
        }
    }
    class MobileNo
    {
        static void Main(string[] args)
        {
            long mob = 7796447207;
            string s = mob.ToString();
            char[] arr = s.ToCharArray();

            Dictionary<char, int> d1 = new Dictionary<char, int>();
            foreach(char c in arr)
            {
                if(d1.ContainsKey(c))
                {
                    int oldval = d1[c];
                    d1[c] = oldval + 1;
                }
                else
                {
                    d1.Add(c, 1);
                }
            }
            Console.ReadLine();
        }
    }
}
