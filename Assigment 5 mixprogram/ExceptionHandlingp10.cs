using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyNewProject1.Assigment_5_mixprogram
{
    //10.WAP to accept a number and check whether it is binary or not.
    //If not  throw custom exception InvalidBinaryNumber.
    class InvalidBinaryNumber:ApplicationException
    {

    }
    class ExceptionHandlingp10
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter binary no");
            int num = int.Parse(Console.ReadLine());
            
            public int binaryno
            {
                set
                {
                    if (binaryno < 0)
                        throw new InvalidBinaryNumber("Incorrect binary no");
                    else
                        this.binaryno= value;
                }
                get { return binaryno; }
            }
        ExceptionHandlingp10 e1 = new ExceptionHandlingp10();
            try
            {
                binaryno();
            }
            catch(Exception e)
            {
                Console.WriteLine("Experience cant be negative");
            }
    }
    
}
