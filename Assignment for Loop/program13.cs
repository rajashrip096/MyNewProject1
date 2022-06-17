using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyNewProject1.Assignment_for_Loop
{
	//Predict the output of following:what are the value of i and j 
	class program13
    {
        static void Main(string[] args)
        {
			int i = 1;
			while (i <= 5)
			{
				int j = 1;
				while (j <= 5)
				{
					if (j == 2)
					{
						break;
						Console.WriteLine(j);
					}
					j++;
				}
				Console.WriteLine(i);
			}
            Console.ReadLine();
		}
	}
}
