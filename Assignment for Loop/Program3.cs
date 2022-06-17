using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyNewProject1.Assignment_for_Loop
{
    //Predict the output of following: 
    class Program3
    {
        static void Main(string[] args)
        {
            int i = 1, k = 1;
            while(i++ <= 5)
            {
                k *= i;
            }
            Console.WriteLine("k = " +k+     " i = " +i);
            Console.ReadLine();
        }
    }
}
