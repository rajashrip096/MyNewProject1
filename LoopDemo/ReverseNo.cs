using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyNewProject1.LoopDemo
{
    //write the code for reverse number
    class ReverseNo
    {
        static void Main(string[] args)
        {


            Console.WriteLine("Enter the no");
            int num = int.Parse(Console.ReadLine());

            int reverse = 0;
            while (num > 0)
            {
                int r = num % 10;
                reverse = reverse * 10 + r;
                num = num / 10;
            }

            Console.WriteLine(reverse);
            Console.ReadLine();
        }


    }
}
