using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyNewProject1.BranchingStatement
{
    class VowelSwitchcase
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter any char");
            string ch = Console.ReadLine();

            switch (ch)
            {
                case "a": Console.WriteLine("Character is Vowel");
                          Console.ReadLine();
                          break;
                case "e": Console.WriteLine("Character is Vowel");
                          Console.ReadLine();
                           break;
                case "i ": Console.WriteLine("Character is Vowel");
                          Console.ReadLine();
                          break;
                case "o": Console.WriteLine("Character is Vowel");
                          Console.ReadLine();
                          break;
                case "u": Console.WriteLine("Character is Vowel");
                          Console.ReadLine();
                         break;
                default:
                    Console.WriteLine("Character is Consonent");
                    Console.ReadLine();
                    break;
            }
        }
    }
}
