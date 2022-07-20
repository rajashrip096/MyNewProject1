using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyNewProject1.CollectionTest
{
    class StackP15
    {
        //15.WAP to create a Stack to store some objects and iterate over it.
        //Also show use od push,pop,peek.
        static void Main(string[] args)
        {
            //LIFO
            Stack<int> st = new Stack<int>();
            st.Push(100);
            st.Push(200);
            st.Push(300);
            st.Push(400);
            st.Push(500);

            st.Pop();
           int datapeek = st.Peek();
            Console.WriteLine("Peek :"+datapeek);
            foreach(int i in st)

                Console.WriteLine(i);
            Console.ReadLine();

        }
    }
}
