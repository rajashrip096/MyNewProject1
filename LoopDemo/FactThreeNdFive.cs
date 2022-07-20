using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyNewProject1.LoopDemo
{
    class FactThreeNdFive
    {
        static void Main(string[] args)
        {
            //int n1;
            Console.WriteLine("enter the no");
            int n = Convert.ToInt32(Console.ReadLine());
           // Console.WriteLine("enter the no");
            //int n1 = Convert.ToInt32(Console.ReadLine());

            for (int i=1;i<=15;i++)
            {
                /*if(n%3==0 && n1%5==0)
                {
                    Console.WriteLine("Red&Blue"); ;
                    Console.ReadLine();
                }
                else if(n1%5==0)
                {
                    Console.WriteLine("Red");
                    Console.ReadLine();
                }
                else
                {
                    Console.WriteLine("Blue");
                    Console.ReadLine();
                }
                Console.WriteLine(i);
                Console.ReadLine(  ); */


                if (n % 3 == 0 && n % 5 == 0)
                {
                    Console.WriteLine("redblue");
                    Console.ReadLine();
                }
                else if(n % 3== 0)
                {
                    Console.WriteLine("Red");
                    Console.ReadLine();
                }
                else if(n % 5 == 0)
                {
                    Console.WriteLine("Blue");
                    Console.ReadLine();
                }
                else
                {
                    Console.WriteLine("false");
                    Console.ReadLine();
                }
            }
        }
    }
}
