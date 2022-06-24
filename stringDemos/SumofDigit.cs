using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyNewProject1.stringDemos
{
    class SumofDigit
    {
        public static int checkSum(string s)
        {
            int sum = 0;
            int count = 0;
            for(int i=0;i<s.Length;i++)
            {
                if(s[i]>='0' && s[i]<='9')
                {
                    int x = (int)char.GetNumericValue(s[i]);
                    sum = sum + x;
                    count++;
                }
            }
            Console.WriteLine("count "+count);
            return sum;

        }
        static void Main(string[] args)
        {
            Console.WriteLine("Enter the string");
            string str = Console.ReadLine();

            int digitsum = SumofDigit.checkSum(str);
            Console.WriteLine(digitsum);
            Console.ReadLine();
        }
    }
    class Sumofdigit2
    {
        public static int checkSum(string s)
        {
            int sum = 0;
            int count = 0;
            for (int i = 0; i < s.Length; i++)
            {
                if (char.IsDigit(s[i]))
                {
                    int x = (int)char.GetNumericValue(s[i]);
                    sum = sum + x;
                    count++;
                }
            }
            Console.WriteLine("count " + count);
            return sum;

        }
        static void Main(string[] args)
        {
            Console.WriteLine("Enter the string");
            string str = Console.ReadLine();

            int digitsum = SumofDigit.checkSum(str);
            Console.WriteLine(digitsum);
            Console.ReadLine();
        }
    }
}
