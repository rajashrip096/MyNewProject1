using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyNewProject1.CollectionDemo
{
    class DictionaeryDemo2
    {
        static void Main(string[] args)
        {
            List<string> ll = new List<string>()
            { "red","pink","yellow","red","blue","pink","red"};
            Dictionary<string, int> dd = new Dictionary<string, int>();
            foreach(string colour in ll)
            {
                if(dd.ContainsKey(colour))
                {
                    int oldvalue = dd[colour];
                    dd[colour] = oldvalue + 1;
                }
                else
                {
                    dd.Add(colour, 1);
                }
            }
            foreach (KeyValuePair<string, int> kp in dd)
                Console.WriteLine(kp.Key + "=>" + kp.Value);
            Console.ReadLine();
        }
    }
    class RemoveElementList
    {
        static void Main(string[] args)
        {
            List<string> ll = new List<string>()
            { "Red","pink","blue","yellow"};
            Console.WriteLine( "Enter the colour to be deleted");
            string colourTodeleted = Console.ReadLine();
            ll.Remove(colourTodeleted);
            while(true)
            {
                int idx = ll.IndexOf(colourTodeleted);
                if (idx != -1)
                    ll.RemoveAt(idx);
                else
                    break;
            }
            foreach(string d in ll)
                Console.WriteLine(d);
            Console.ReadLine();
        }
    }
}
