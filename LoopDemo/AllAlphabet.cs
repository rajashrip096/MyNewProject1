using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyNewProject1.LoopDemo
{
    class AllAlphabet
    {
        static void Main(string[] args)
        {
            char i;
           /* Console.WriteLine("Enter the U for uppercase alphabet");
            Console.ReadLine();
           // char i = Convert.ToChar(Console.ReadLine());
           Console.WriteLine("Enter the l lower case alphabet");
            Console.ReadLine();
            //char i = Convert.ToChar(Console.ReadLine());
            // if(i= 'U' || i = 'u')*/
            for (i= 'A'; i <= 'Z'; i++)
                {
                    Console.WriteLine(i);
                    Console.ReadLine();
                }
           // else if(i='L' || i='l')
            {
                for(i = 'a' ;i <= 'z';i++)
                {

                    Console.WriteLine(i);
                    Console.ReadLine();

                }
            }
        }
    }
}
