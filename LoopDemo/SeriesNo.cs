
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyNewProject1.LoopDemo
{
    class SeriesNo
    {
        static void Main(string[] args)
        {
            //2,5,10,17...
           /* for (int i=1;i<=10;i++)
            {
                Console.WriteLine(i*i+1);
                Console.ReadLine();
            }*/
            //2,12,36,80
            /*
             * for(int i=1;i<=10;i++)
            {
                Console.WriteLine((i*i)+(i*i*i));
                Console.ReadLine();
            }*/
            //1,3,8,36
            for(int i=0;i<=10;i++)
            { 
                Console.WriteLine(i*i-1);                                                
                
                i++;
            }
            Console.ReadLine();
        }
    }
}
