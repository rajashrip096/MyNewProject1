using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyNewProject1.Assignment_for_Loop
{
    // WAP to print following pattern. 
    /*      1
          2 2 2
         3 3 3 3 3
        4 4 4 4 4 4 4 */

class PatternNumber
{
   static void Main(string[] args)
   {
       for(int i=1;i<=4;i++)
       {
           for(int j=1;j<=i;j++)
           {
               Console.Write(i);
           }
           Console.WriteLine();
       }
       Console.ReadLine();
   }
}
}
