using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyNewProject1.CollectionDemo
{
    class StackDemo
    {
        static void Main(string[] args)
        {
            //Fist in Last out
            Stack<string> st = new Stack<string>();
            st.Push("A");
            st.Push("B");
            st.Push("C");

            //st.Clear();
            string[] arr = new string[st.Count];
            st.CopyTo(arr, 0);
            foreach(string d in arr)
                Console.WriteLine(d);
            string dataremove = st.Pop();
            string datapeek = st.Peek();
            Console.WriteLine("Peek "+datapeek);
            foreach(string d in st)
            {
                Console.WriteLine(d);
            }
            Console.ReadLine();
        }
    }
}
