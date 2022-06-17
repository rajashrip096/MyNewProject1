using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyNewProject1.Assignment_for_Loop
{
    class SeriesNo
    {
        //    Print the Series  2 12 36 80 150 252....upto 10 terms

        static void Main(string[] args)
        {
            for(int i=1;i<=10;i++)
            {
                Console.WriteLine((i*i)+(i*i*i));
            }
            Console.ReadLine();
        }
    }
}
