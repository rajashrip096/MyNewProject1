using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyNewProject1.BranchingStatement
{
    class LeafYear
    {
        static void Main(string[] args)
        {
            //int y;
            Console.WriteLine("enter the year in four digit");
            int y = Convert.ToInt32(Console.ReadLine());

            if((y % 4 == 0) && (y % 100!=0) || (y % 400== 0))
            {
                Console.WriteLine("This is Leaf Year"+y);
                Console.ReadLine();
            }
            else
            {
                Console.WriteLine("This is Not Leap Year" +y);
                Console.ReadLine();
            }
        }
    }
}
