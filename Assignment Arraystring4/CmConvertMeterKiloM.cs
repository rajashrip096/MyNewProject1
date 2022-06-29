using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyNewProject1.Assignment_Arraystring4
{
    //Write a program to enter length in centimeter and
    //convert it into meter and kilometer.
    class CmConvertMeterKiloM
    {
        static void Main(string[] args)
        {
            int[] a = new int[5];
            double Meter, Kilometer;
            double centim;
            Console.WriteLine("Enter the length in centimeter");
            centim = Convert.ToDouble(Console.ReadLine());
           
            Meter = centim / 100.0;
            Kilometer = centim / 100000.0;
            Console.WriteLine("Cm converted Meter = "+Meter);
            Console.WriteLine("Cm converted kilometer = "+Kilometer);
            Console.ReadLine();
        }
    }
}
