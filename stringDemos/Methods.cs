using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyNewProject1.stringDemos
{
    class Methods
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter the string");
            String str = Console.ReadLine();
            int l = str.Length;
            Console.WriteLine(l);
            Console.WriteLine(".................................");

            string newUpper = str.ToUpper();
            Console.WriteLine(newUpper);
            Console.WriteLine("..................................");

            string newLower = newUpper.ToLower();
            Console.WriteLine(newLower);
            Console.WriteLine("...................................");

            char[] ch = str.ToCharArray();
            Console.WriteLine(string.Join(" ",ch));
            Console.WriteLine("....................................");

            string substringnew = str.Substring(3);
            Console.WriteLine(substringnew);

            string sub2 = str.Substring(3, 6); //strat index,number of char
            Console.WriteLine( sub2);

            Console.WriteLine(str[0]+" "+str[str.Length-1]);

            Console.WriteLine("......................................");
            String[] Words = str.Split();

            foreach (string st in Words)
            {
                Console.WriteLine(st);
            }
            Console.WriteLine("........................................");

            Console.WriteLine(str.IndexOf('i'));
            Console.WriteLine(str.LastIndexOf('i'));
            Console.ReadLine();


        }
    }
}
