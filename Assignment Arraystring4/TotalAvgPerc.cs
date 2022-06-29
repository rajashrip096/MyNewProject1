using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyNewProject1.Assignment_Arraystring4
{
    //Write a program to enter marks of five subjects and calculate total,
    //average and percentage.
    class TotalAvgPerc
    {
        static void Main(string[] args)
        {
            int[] a = new int[5];
            int phy, chem, math, eng, bio;
            int Total;
            double avg, perc;
            Console.WriteLine("Enter the five subject marks");
            phy = int.Parse(Console.ReadLine());
            chem = int.Parse(Console.ReadLine());
            math = int.Parse(Console.ReadLine());
            eng = int.Parse(Console.ReadLine());
            bio = int.Parse(Console.ReadLine());

            Total = phy + chem + math + eng + bio;
            avg = Total / 5;
            perc = (Total * 100) / 500;
            Console.WriteLine("Total marks is = "+Total);
            Console.WriteLine("Average is = "+avg);
            Console.WriteLine("Percentage is = "+perc);
            Console.ReadLine();


        }
    }
}
