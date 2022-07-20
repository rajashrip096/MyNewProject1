using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyNewProject1.Practiceinterview
{
    class PrimeNo
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter the no");
            int num = Convert.ToInt32(Console.ReadLine());
            int count = 0;
            for(int i=2;i<num;i++)
            {
                if(num%i==0)
                {
                    count++;
                    break;
                }
            }
            if(count==0)
            {
                Console.WriteLine("number is prime");
            }
            else
            {
                Console.WriteLine("number is not prime");
            }
            Console.ReadLine();
        }
    }
}
