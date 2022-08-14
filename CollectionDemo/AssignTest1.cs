using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyNewProject1.CollectionDemo
{
    class AssignTest1
    {
        //Wriote a program to accept two number & find a raise to b
        static void Main(string[] args)
        {
            int n1 = int.Parse(Console.ReadLine());
            int exp = int.Parse(Console.ReadLine());
            int result = 1;
            for(int i=1;i<=exp;i++)
            {
                result = result * n1;
            }
            Console.WriteLine(result);
            Console.ReadLine();
        }
        
    }
}
