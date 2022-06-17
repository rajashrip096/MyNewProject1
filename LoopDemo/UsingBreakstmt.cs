using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyNewProject1.LoopDemo
{
    class UsingBreakstmt
    {
        static void Main(string[] args)
        {
             /*int i = 1;

            while (i <= 5)
            {
                Console.WriteLine(i);
                Console.ReadLine();
                break;
                i++;
            }*/
             for(int i=1;i<=10;i++)
             {
                if (i == 5)
                {
                    break;
                    //continue;
                }
                Console.WriteLine(i);
                Console.ReadLine();
             }
            Console.WriteLine("after the loop");
        }
            
        
    }
}
