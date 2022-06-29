using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyNewProject1.Assignment_Arraystring4
{
    class DuplicateWord
    {
        //1 .Write a  program to find the duplicate words and their
        //number of occurrences in a string
        static void Main(string[] args)
        {
            Console.WriteLine("enter the string");
            string s = Console.ReadLine();
            string[] str = s.Split(' ');
            
           

            for (int i = 0; i < str.Length; i++)
            {
                int count = 1;
                bool isVisited = false;
                for (int k = i-1; k>=0;k--)
                {
                    if (str[i] == str[k])
                    {
                        isVisited = true;
                        break;
                    }
                }
                if (isVisited == false)
                {
                    for (int j = i+1; j < str.Length; j++)
                    {
                        if (str[i] == str[j])
                        {
                            count++;
                        }
                     
                    }
                    if (count > 1)
                    {
                        Console.WriteLine("Duplicate word " + str[i] + " " + count);

                    }
                }
            }
            Console.ReadLine();


        }
           

    }
}

