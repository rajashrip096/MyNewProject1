using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyNewProject1.Practiceinterview
{
    class PalindromNo
    {
        static void Main(string[] args)
        {
            int n, r, rev = 0, temp;
            Console.WriteLine("Enter the no");
            n = int.Parse(Console.ReadLine());
            temp = n;
            do
            {
                r = n % 10;
                rev = (rev * 10) + r;
                n = n / 10;
            }
            while (n != 0);
            {
                if(rev==temp)
                {
                    Console.WriteLine("number is palindrom");
                }
                else
                {
                    Console.WriteLine("number is not palindrom");
                }
            }
            Console.ReadLine();
        }
    }
}
