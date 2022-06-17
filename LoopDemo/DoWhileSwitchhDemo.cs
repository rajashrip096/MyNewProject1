using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyNewProject1.LoopDemo
{
    class DoWhileSwitchhDemo
    {
        static void Main(string[] args)
        {
            char ch;
            do
            {
                Console.WriteLine("Enter the 1st number");
                int num1 = int.Parse(Console.ReadLine());
                Console.WriteLine("Enter the 2nd number");
                int num2 = int.Parse(Console.ReadLine());

                Console.WriteLine("1.Addition \n2.Subtraction \n3.Multiplication \n4.Divion");
                Console.WriteLine("Enter the Choice");
                int choice = int.Parse(Console.ReadLine());
                switch (choice)
                {
                    case 1:
                        Console.WriteLine("Addition is =" + (num1 + num2));
                        break;
                    case 2:
                        Console.WriteLine("Addition is =" + (num1 - num2));
                        break;
                    case 3:
                        Console.WriteLine("Addition is =" + (num1 * num2));
                        break;
                    case 4:
                        Console.WriteLine("Addition is =" + (num1 / num2));
                        break;
                    default:
                        Console.WriteLine("Invalid");
                        break;
                }
                Console.WriteLine("Do you want to continue");
                ch = Console.ReadLine()[0];
            } while (ch == 'Y' || ch == 'y');
        }
    }
}
