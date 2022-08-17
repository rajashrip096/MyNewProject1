using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyNewProject1.Assigment_5_mixprogram
{
    class PatternProgram9
    {
        /*9.WAP to draw the following pattern using . Note: Input is an odd number: [1M]*
                     12345
                     ABCD
                     123
                     AB
                     1
                     AB
                     123
                     ABCD
                     12345*/
        static void Main(string[] args)
        {
            for(int i=1;i<=5;i++)
            {
                char ch = 'A';
                int count = 1;
                for(int j=6-i;j>0;j--)
                {
                    if(i%2!=0)
                    {
                        Console.Write(count);
                        count++;  
                    }
                    else
                    {
                        Console.Write(ch);
                        ch++;
                    }
                }
                Console.WriteLine();
            }
            for(int i=2;i<=5;i++)
            {
                char ch = 'A';
                int count = 1;
                for(int j=1;j<=i;j++)
                {
                    if (i % 2 != 0)
                    {
                        Console.Write(count);
                        count++;
                    }
                    else
                    {
                        Console.Write(ch);
                        ch++;
                    }
                }
                Console.WriteLine();
            }
            Console.ReadLine();
        }

    }
    class Pattern2
    {
    }

}
