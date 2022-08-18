using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyNewProject1.Assigment_test_Pena4
{
    ////Write a C# Program to Get Month Name From Month Number using Switch Case 
    class MonthSCp2
    {
        static void Main(string[] args)
        {
            int MonthNo;
            Console.WriteLine("Enter the month no(1-12)");
            MonthNo = int.Parse(Console.ReadLine());
            switch (MonthNo)
            {
                case 1:
                    Console.WriteLine("January");
                    break;
                case 2:
                    Console.WriteLine("February");
                    break;
                case 3:
                    Console.WriteLine("March");
                    break;
                case 4:
                    Console.WriteLine("April");
                    break;
                case 5:
                    Console.WriteLine("May");
                    break;
                case 6:
                    Console.WriteLine("Jun");
                    break;
                case 7:
                    Console.WriteLine("July");
                    break;
                case 8:
                    Console.WriteLine("August");
                    break;
                case 9:
                    Console.WriteLine("September");
                    break;
                case 10:
                    Console.WriteLine("November");
                    break;
                case 11:
                    Console.WriteLine("December");
                    break;
                default:
                    Console.WriteLine("you did not enter correct value for month name ");
                    break;
            }
            Console.ReadLine();

        }
    }
}
