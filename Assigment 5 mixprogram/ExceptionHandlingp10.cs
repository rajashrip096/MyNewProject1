using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyNewProject1.Assigment_5_mixprogram
{
    //10.WAP to accept a number and check whether it is binary or not.
    //If not  throw custom exception InvalidBinaryNumber.
    class InvalidBinaryNumberException:ApplicationException
    {
        public InvalidBinaryNumberException(string msg):base(msg)
        {

        }
    }
    class ExceptionHandlingp10
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter binary no");
            int bin = int.Parse(Console.ReadLine());
            bool isbinary = true;

            while (bin > 0)
            {
                int digit = bin % 10;
                if (digit>1)
                {
                    throw new InvalidBinaryNumberException("Binary number should have 0 or 1 only");
                }
                bin = bin / 10;
            }
          ExceptionHandlingp10 e1 = new ExceptionHandlingp10();
              try
              {
                 bin = int.Parse(Console.ReadLine());
              }
              catch(Exception e)
              {
                  Console.WriteLine("Experience cant be negative");
              }
            Console.WriteLine(e1);
        }
    }
    
}
