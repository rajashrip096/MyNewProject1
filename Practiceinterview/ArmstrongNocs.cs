using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyNewProject1.Practiceinterview
{
    class ArmstrongNocs
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter the no");
            int num = int.Parse(Console.ReadLine());
            int temp;
            int sum = 0;
            temp = num;
            while(num>0)
            {
                int r = num % 10;
                sum = sum + (r * r * r);
                num = num / 10;
            }
            if(sum==temp)
            {
                Console.WriteLine("number is armstrong");
            }
            else
            {
                Console.WriteLine("number is not armstrong");
            }
            Console.ReadLine();
        }
    }
}
