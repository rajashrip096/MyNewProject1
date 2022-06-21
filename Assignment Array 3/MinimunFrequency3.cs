using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyNewProject1.Assignment_Array_3
{
    //Write a program to find Minimum frequency char from an Array
    class MinimunFrequency3
    {
        static void Main(string[] args)
        {
            char[] arr = { 'a', 'b', 'b', 'c', 'c', 'b' };

            for (int i = 0; i < arr.Length; i++)
            {
                bool isVisited = false;

                int count = 1;
                for (int k = i - 1; k >= 0; k--)
                {
                    if (arr[i] == arr[k])
                    {
                        isVisited = true;
                        break;
                    }
                }
                if (isVisited == false)
                {
                    for (int j = i + 1; j < arr.Length; j++)
                    {
                        if (arr[i] == arr[j])
                        {
                            count++;
                        }
                    }
                    if (count == 1)
                    {
                        Console.WriteLine(arr[i] + "  " + count);
                        Console.ReadLine();
                    }
                }
            }
        }
    }
}
