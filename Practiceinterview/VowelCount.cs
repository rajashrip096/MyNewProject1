using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyNewProject1.Practiceinterview
{
    class VowelCount
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter the name");
            string str = Console.ReadLine();
            int vowelcount = 0;
            int consonentcount = 0;

            for(int i=0;i<str.Length;i++)
            {
                if(str[i]=='a' || str[i]=='i' ||str[i]=='e'||str[i]=='o'||str[i]=='u')
                {
                    vowelcount++;
                }
                else
                {
                    consonentcount++;
                }
            }
            Console.WriteLine("vowel count is "+vowelcount);
            Console.ReadLine();
        }
    }
}
