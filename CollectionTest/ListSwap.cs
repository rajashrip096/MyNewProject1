using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyNewProject1.CollectionTest
{
    class ListSwap
    {
        static void Main(string[] args)
        {
            List<int> ll = new List<int> { 2,4,1,5,6,7,8};

                    int temp = ll[1];
                    ll[1] = ll[2];
                    ll[2] = temp;
            
            foreach(int c in ll)
                Console.WriteLine(c);
            Console.ReadLine();
        }
    }
}
    

