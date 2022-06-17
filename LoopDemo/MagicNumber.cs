using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyNewProject1.LoopDemo
{
    class MagicNumber
    {
        static void Main(string[] args)
        {
            int magicnumber = 67;
            for (; ; )
            {
                Console.WriteLine("Enter the Number");
                int num = int.Parse(Console.ReadLine());

                if (num < magicnumber)
                {
                    Console.WriteLine("Number is less than magic Number pls try again...");
                    Console.ReadLine();
                    continue;
                }
                else if (num > magicnumber)
                {
                    Console.WriteLine("Number is greater pls try again....");
                    Console.ReadLine();
                    continue;
                }
                else
                {
                    Console.WriteLine("Congratulation Number is match....");
                    Console.ReadLine();
                    break;
                }
            }
        }
    }
    class MagicNumberWhileLoop
    {
        static void Main(string[] args)
        {
            int magicnumber = 67;

            Console.WriteLine("enter the number");
            int num=int.Parse(Console.ReadLine());
            while(num==magicnumber)
            {
                Console.WriteLine("Congratulation number  match");
                Console.ReadLine();
                if (num < magicnumber)
                {
                    Console.WriteLine("no is less than magic no");
                    Console.ReadLine();
                    continue;

                }
                else
                {
                    Console.WriteLine("no is greater than magic no");
                    Console.ReadLine();
                    continue;
                }
            }
        }
    }
}
