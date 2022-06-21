using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyNewProject1.Assignment_Array_3
{
    //Predict the output: 
    class Class2
    {
        static int mcCartyCounter = 100;
        public static int mcCarthy(int n)
        {
            mcCartyCounter++;
            if (n > 100)
                return n - 10;
            else
                return mcCarthy(n + 11);
        }
        public static void Main(string[] arg)
        {
            Console.WriteLine(mcCarthy(100) + "  " + mcCartyCounter);
            Console.ReadLine();
        }

        //output 101  102
    }
}

