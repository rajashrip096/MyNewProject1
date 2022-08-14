using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace MyNewProject1.CollectionTest
{
    class MockStringRemovcs
    {
		static void Main(string[] args)
		{
			string str = "rajashri";
			Console.WriteLine("first string : " + str);
			List<char> unique = new List<char>(str);

			HashSet<char> h1 = new HashSet<char>(unique);

			foreach (var c in h1)
				Console.WriteLine(c);
            Console.ReadLine();

		}
	}
}
