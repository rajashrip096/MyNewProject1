using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyNewProject1.BranchingStatement
{
    class SwitchDemo1
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter the value");
            int num = int.Parse(Console.ReadLine());
            
            /*Console.WriteLine("Enter your choice");
            int num=int.parse(Console.ReadLine());*/

            switch(num)
            {
                case 1: 
                    Console.WriteLine("Monday");
                    Console.ReadLine();
                    break;
                case 2:
                    Console.WriteLine("Tuesday");
                    Console.ReadLine();
                    break;
                case 3:
                    Console.WriteLine("Wednesday");
                    Console.ReadLine();
                    break;
                 case 4:
                    Console.WriteLine("Thursday");
                    Console.ReadLine();
                    break;
                case 5 :
                    Console.WriteLine("Friday");
                    Console.ReadLine();
                    break;
                case 6 :
                    Console.WriteLine("Saturday");
                    Console.ReadLine();
                    break;
                case 7:
                    Console.WriteLine("Sunday");
                    Console.ReadLine();
                    break;
                default:
                    Console.WriteLine("Invalid input");
                    Console.ReadLine();
                    break;
            }


        }
    }
}
