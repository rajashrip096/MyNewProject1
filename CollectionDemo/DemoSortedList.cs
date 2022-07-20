using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyNewProject1.CollectionDemo
{
    class myStringBuilderSort : IComparer<StringBuilder>
    {
        public int Compare(StringBuilder x,StringBuilder y)
        {
            return x.ToString().CompareTo(y.ToString());
        }
    }
    class DemoSortedList
    {
        static void Main(string[] args)
        {
            SortedList<StringBuilder, int> sb = new SortedList<StringBuilder, int>(new myStringBuilderSort());
            sb.Add(new StringBuilder("Amit"), 90000);
            sb.Add(new StringBuilder("smit"), 90000);
            sb.Add(new StringBuilder("Priya"), 90000);
            sb.Add(new StringBuilder("Meei"), 90000);
            sb.Add(new StringBuilder("Amita"), 90000);
            foreach(KeyValuePair<StringBuilder,int> kv in sb)
                Console.WriteLine(kv.Key + "===>" +kv.Value);
            Console.ReadLine();
        }
    }
}
