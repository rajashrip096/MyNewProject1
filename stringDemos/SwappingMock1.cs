using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyNewProject1.stringDemos
{
	//rotating swapping
    class SwappingMock1
    {
        static void Main(string[] args)
        {

			int[] a = { 4, 5, 6, 7, 1 };
			for (int i = 0; i < a.Length; i++)
			{
				for (int j = 0; j < a.Length; j++)
				{

					int temp = a[i];
					a[i] = a[j];
					a[j] = temp;
					Console.WriteLine(a[i]);
				}
				
			}
			
			Console.ReadLine();
		}
	}
}
