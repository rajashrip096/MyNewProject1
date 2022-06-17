using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyNewProject1.LoopDemo
{
    class Square
    {
        //write the code 1 to 20 numbers.
        static void Main(string[] args)
        {
            int x;
            Console.WriteLine("enter the number");
             x = Convert.ToInt32(Console.ReadLine());
            
            Console.WriteLine("\n");
            for ( x = 1; x <= 20; x++)
            {
                Console.WriteLine((x * x ));
               
            }
            Console.ReadLine();
        }
    }
}
