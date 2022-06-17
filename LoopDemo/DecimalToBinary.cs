using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyNewProject1.LoopDemo
{
    class DecimalToBinary
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter the decimal number");
            int num = int.Parse(Console.ReadLine());

            
            string binary = "";
            while(num>0)
            {

                int r = num % 2;
                binary = r + binary;
                num = num / 2;
              
            }
            Console.WriteLine(binary);
            Console.ReadLine();

        }
    }
    class BinaryToDecimal
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter the Binary number");
            int num = int.Parse(Console.ReadLine());

            int sum = 0;
            int p = 0;
            while(num>0)
            {
                int r = num % 10;
                int Power = (int)(Math.Pow(2, p));
                sum = sum + (Power * r);
                num = num / 10;
                p++;
            }
            Console.WriteLine(sum);
            Console.ReadLine();
        }
    }
}
