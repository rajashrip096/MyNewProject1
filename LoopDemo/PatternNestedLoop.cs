



using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyNewProject1.LoopDemo
{
    //write the code to print 1 to 5 table
    class PatternNestedLoop
    {
        static void Main(string[] args)
        {
            //table 1 to 5 print
            int table,num;

            for(int i=1;i<=5;i++)
            {
                for (int j = 0; j <= 10; j++)
                {
                    Console.WriteLine(i*j);
                    
                }
                Console.WriteLine();
            }
            Console.ReadLine();
        }
        
    }
    class PatternStarLoop
    {
        static void Main(string[] args)
        {
            //****
            //***
            //**
            //*   pattern
            for(int i=1;i<=4;i++)
            {
                for(int j=4;j>=i;j--)
                {
                    Console.Write("*");
                    Console.ReadLine();
                }
                Console.WriteLine();
            }
        }
    }
}
