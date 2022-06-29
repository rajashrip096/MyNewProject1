using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyNewProject1.Assignment_Arraystring4
{
    //9.Write a Java program to enter P, T, R and calculate Simple Interest.
    class SimpleInterest
    {
        static void Main(string[] args)
        {
            int[] a = new int[5];
            int P, R, T;
            Console.WriteLine("Enter the no");
            P = int.Parse(Console.ReadLine());
            R = int.Parse(Console.ReadLine());
            T = int.Parse(Console.ReadLine());

           int  Si = P * R * T;
            Console.WriteLine("Simple Interest is = "+Si);
            Console.ReadLine();
        }
    }
}
