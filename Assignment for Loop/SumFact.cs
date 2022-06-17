using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyNewProject1.Assignment_for_Loop
{
    //1!+2!+3!+4!...n WAP a program to find sum
    class SumFact
    {
        static void Main(string[] args)
        {
            Console.WriteLine("enter the number");
            int n = int.Parse(Console.ReadLine());
            int sum=0;
            int Fact =1;
            for(int i=1 ; i<=5 ; i++)
            {
                Fact = Fact * i;
                sum += Fact;
                Console.WriteLine(sum);
            }
            Console.ReadLine();
        }
    }
}
