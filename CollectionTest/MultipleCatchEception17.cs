using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyNewProject1.CollectionTest
{
    class MultipleCatchEception17
    {
        //17.WAP to show  exception and use multiple catch block with
        //universal Exception handler.
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome");
            Console.WriteLine("Enter the no");
            try
            {
                int a = int.Parse(Console.ReadLine());
                int b = int.Parse(Console.ReadLine());
                Console.WriteLine("Division :" + a / b);
                try
                {
                    Console.WriteLine("Enter the age");
                    int c = int.Parse(Console.ReadLine());

                }
                catch (NullReferenceException e)
                {
                    Console.WriteLine(e.Message);

                }
                Console.WriteLine("Try ends");
            }
            catch (DivideByZeroException e)
            {
                Console.WriteLine("1");
                Console.WriteLine(e.Message);
            }
            catch (FormatException e)
            {
                Console.WriteLine("2");
                Console.WriteLine(e.Message);
            }
            catch (SystemException e)
            {
                Console.WriteLine(e.Message);
            }
            for (int i = 0; i <= 10; i += 2)
            {
                Console.WriteLine(i);
            }
            Console.ReadLine();
        }
    }
}
