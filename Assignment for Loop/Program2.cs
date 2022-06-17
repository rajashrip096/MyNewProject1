using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyNewProject1.Assignment_for_Loop
{
    //Predict behaviour of the following code: 
    class Program2
    {
        static void Main(string[] args)
        {
            int b = 0;
            do
            {
                int a = 1;
                b++;
                Console.WriteLine(a++);

            } while (b != 3);
            Console.ReadLine();
        }
    }
}
