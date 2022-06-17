using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyNewProject1.Assignment_for_Loop
{
    //write a program to check given number is trimorphic  number or not
    //4 is trimorphic number as its cube(64) contains 4  at the end.
    //5 is trimorphic number as its cube(625)contains 5 at the end.

    class TrimorphicNo
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter the number");
            int num = Convert.ToInt32(Console.ReadLine());
            int count = 0;
            int temp = num;
            while(num>0)
            {
                count++;
                num = num % 10;
            }
            //Console.WriteLine(count);
            //Console.ReadLine();
            temp = num;
            int cube = num * num * num;
            int power = 1;
            for(int i=0;i<=count;i++)
            {
                power = power * 10;
            }
            //Console.WriteLine(cube+" "+power);
            //Console.ReadLine();
            int end = cube % power;
            Console.WriteLine(cube+" "+"end" +end);
            if(end==num)
            {
                Console.WriteLine("Number is trimorphic");
            }
            else
            {
                Console.WriteLine("Number is not trimorphic");
            }
            Console.ReadLine();
        }
    }
}
