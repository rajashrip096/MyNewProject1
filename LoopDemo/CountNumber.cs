using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyNewProject1.LoopDemo
{
    class CountNumber
    {
        static void Main(string[] args)
        {
            int num2,count = 0;
            Console.WriteLine("Enter any number");
            num2 = Convert.ToInt32(Console.ReadLine());
            while(num2>0)
            /*{
                num2 = num2 / 10;
                count = count + 1;
            }*/
            for (count = 0; num2 > 0; num2 = num2/10)
            {
                count = count + 1;
              
            }
            Console.WriteLine("Count number is " +count);
            Console.ReadLine();

        }
    }
}
