using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyNewProject1.ConditinalDemo
{
    class CharalphaDigitSymbol
    {
        static void Main(string[] args)
        {
            //char ch;
            Console.WriteLine("Enter the character");
            //Console.ReadLine();
            char ch = Convert.ToChar(Console.ReadLine());

            if((ch>='a' && ch<= 'z') || (ch>= 'A' && ch<= 'Z'))
             {
                Console.WriteLine( ch+ "is an alphabet");
                Console.ReadLine();
             }
            else if(ch>='0'&& ch<='9')
            {
                Console.WriteLine(ch+ "is a Digit");
                Console.ReadLine();
            }
            else 
            {
                Console.WriteLine( ch+ "is a Speacial character");
                Console.ReadLine();
            }
        }
    }
}
