using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyNewProject1.BranchingStatement
{
    class SimpleCalculatorSwitchCase
    {
        static void Main(string[] args)
        {
            //int num1,num2,result = 0;
            Console.WriteLine("Enter the 1st value");
           int a = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter the 2nd value");
            int b = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("+ \n - \n * \n / \n");
            Console.WriteLine("Enter the operator");
            string op = (Console.ReadLine());
            Console.ReadLine();
            switch(op)
                {

                case "+": Console.WriteLine("Addition is" + (a+b));
                            Console.ReadLine();
                          
                            break;

                case "-" : Console.WriteLine("Subtraction is " + (a-b));
                             Console.ReadLine();
                            
                            break;

                case "*" : Console.WriteLine("Multiplication is " + (a*b));
                            Console.ReadLine();
                             break;
                           
                case "/" : Console.WriteLine("Division is "+ (a/b));
                           Console.ReadLine();
                            break;  
                        
                default : Console.WriteLine("Invalid Choice");
                            Console.ReadLine();
                            break;

            }
       
        }
    }
}
