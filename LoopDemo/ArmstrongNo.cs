using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyNewProject1.LoopDemo
{
    class ArmstrongNo
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter the number");
            int num = int.Parse(Console.ReadLine());

            int temp ;
            int sum = 0;
            temp = num;
            while(num>0)
            {
                int r = num % 10;
                sum = sum + (r * r * r);
                num = num / 10;
            }
            if(temp==sum)
            {
                Console.WriteLine("Armstrong number");
                Console.ReadLine();
            }

            else
            {
                Console.WriteLine("Not Armstrong number");
                Console.ReadLine();
            }
        }
    }
}
