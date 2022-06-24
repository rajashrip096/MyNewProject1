using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyNewProject1.stringDemos
{
    class PallindromOrNot
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter the string");
            string str = Console.ReadLine();
            
            string reverse = "";
            for (int i= str.Length - 1;i>=0; i--)
            {
                reverse = reverse+ str[i].ToString();
            }
            if(reverse==str)
            {
                Console.WriteLine("String is Pallindrom");
            }
            else
            {
                Console.WriteLine("String is not pallindrom ");
            }
            Console.ReadLine();
        
        }
    }
}
