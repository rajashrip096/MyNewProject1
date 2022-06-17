using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyNewProject1.LoopDemo
{
    // write the code to print the Table .
    class PrintTable
    {
        static void Main(string[] args)
        {
            int num, i, table;
           Console.WriteLine("Enter the number");
            num = Convert.ToInt32(Console.ReadLine());
            for(i=1;i<=10;i++)
            {
                table = num * i;
                Console.WriteLine(num+"*"+i+ " = " +table);
                Console.ReadLine();

            }
        }
    }
}
