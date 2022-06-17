using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyNewProject1.LoopDemo
{
    class Automorphic
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter the number");
            int num = int.Parse(Console.ReadLine());
            int count = 0;
            int temp = num;
            while(num>0)
            {
                count++;
                num = num / 10;
            }
            //Console.WriteLine(count);
            //.+Console.ReadLine();
            num = temp;
            int sq = num * num;
            int power = 1;
            for(int i=1;i<=count;i++)
            {
                power = power * 10;
            }
           // Console.WriteLine(sq+" " +power);
            int end = sq % power;
            Console.WriteLine(sq+ " "+"end = "+end);
            if(end==num)
            {
                Console.WriteLine("Automorphic ");
            }
            else
            {
                Console.WriteLine("Not Automorphic");
               
            }
        Console.ReadLine();
        }
    }
}
