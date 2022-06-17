using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyNewProject1.Assignment_1
{
    class PercentageAvgTotal
    {
        static void Main(string[] args)
        {
            int math, phy, chem, eng, comp;
            double Percentage, Avg;
            int Total;
            Console.WriteLine("Enter the five subject marks ");
            math = Convert.ToInt32(Console.ReadLine());
            phy = Convert.ToInt32(Console.ReadLine());
            chem = Convert.ToInt32(Console.ReadLine());
            eng = Convert.ToInt32(Console.ReadLine());
            comp = Convert.ToInt32(Console.ReadLine());

            Total = math + phy + chem + eng + comp;
            Avg = Total / 5.0;
            Percentage = (Total / 500.0) * 100;
            Console.WriteLine("Total is = " +Total );
            Console.WriteLine("Average is = "+Avg);
            Console.WriteLine("Percentage is = "+Percentage);
            Console.ReadLine();
        }
    }
}

