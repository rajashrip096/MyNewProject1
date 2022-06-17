using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyNewProject1.LoopDemo
{
    class NumbePattern
    {
        static void Main(string[] args)
        {
            //1 2 3 4 
            //2 3 4
            //3 4
            //4
            for (int i = 1; i <= 4; i++)
            {

                for (int j = i; j <= 4; j++)
                {
                    Console.Write(j + " ");
                 //   Console.ReadLine();
                }
                Console.WriteLine();
            }
            Console.WriteLine("///////////");

            //  Console.ReadLine();
            //1 2 3 4 
            //1 2 3
            //1 2 
            //1
            for (int i = 4; i >= 1; i--)
            {
                for (int j = 1; j <= i; j++)
                {
                    Console.Write(j + " ");
                }
                Console.WriteLine();

            }

            Console.WriteLine("//////////////////////////");
            //1
            //1 2 
            //1 2 3
            //1 2 3 4

            int k = 1;
            for (int i=1;i<=4;i++)
            {
                for(int j=1;j<=i;j++)
                {
                    Console.Write(j+ " ");
                    k++;
                }
                Console.WriteLine();
            }

            Console.WriteLine("////////////////////");

            //1
            //1 0
            //1 0 1
            //1 0 1 0
            int n=4;
            for(int i=1;i<=4;i++)
            {
                for(int j=1;j<=i;j++)
                {
                        Console.Write(j%2);
                }
                Console.WriteLine();
            }

            Console.WriteLine("//////////////////");

            //1
            //A B
            //1 2 3
            //A B C D
            int c = 64;
            for(int i=1;i<5;i++)
            {
                for(int j=1;j<=i;j++)
                {
                    if (i % 2 == 0)
                    {
                        Console.Write((char)(c + j));
                    }
                    else
                    {
                        Console.Write(j);
                    }
                }
                Console.WriteLine();

            }
            Console.ReadLine();
        }
    }
    class NumberPattern1
    {
        static void Main(string[] args)
        {
            //4 3 2 1
            //4 3 2
            //4 2
            //4
            for(int i=1;i<=4;i++)
            {
                for(int j=4;j>=i;j--)
                {
                    Console.Write(j+ " ");
                  //  Console.ReadLine();
                }
                Console.WriteLine();
            }

            Console.ReadLine();

        }
    }
}
