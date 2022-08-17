using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyNewProject1.Assigment_5_mixprogram
{
    //4.Given two LinkedList, we need to combine two LinkedList  in such a way that the
    //combined a List has alternate elements of both. If one list has extra element, then
    //these elements are appended at the end of the combined list.
        /*Input : list1 = {1, 2, 3, 4, 5, 6}
        List2 = { 11, 22, 33, 44}
        List3: { 1, 11, 2, 22, 3, 33, 4, 44, 5, 6}*/
class Linkedlistp4
    {
        static void Main(string[] args)
        {
            LinkedList<int> list1 = new LinkedList<int>();
            list1.AddLast(1);
            list1.AddLast(2);
            list1.AddLast(3);
            list1.AddLast(4);
            list1.AddLast(5);
            list1.AddLast(6);

            LinkedList<int> list2 = new LinkedList<int>();
            list2.AddLast(11);
            list2.AddLast(22);
            list2.AddLast(33);
            list2.AddLast(44);
           
            LinkedList<int> ll = new LinkedList<int>();
            int i = 0;
            int k = 0;//Common
            //i-new ll add
            while(ll.Count<list1.Count+list2.Count)
            {
                if (k < list1.Count && k < list2.Count)
                {
                    ll.AddLast(list1.ElementAt(k));
                    ll.AddLast(list2.ElementAt(k));
                    k++;
                }
                else if(k<list1.Count)
                {
                    ll.AddLast(list1.ElementAt(k));
                    k++;
                }
                else
                {
                    ll.AddLast(list2.ElementAt(k));
                    k++;
                }
            }
            foreach(int d in ll)
                Console.WriteLine(d+" ");
            Console.WriteLine("*************************************");

            foreach(int d in list2)
                Console.WriteLine(d+" ");
            Console.WriteLine("***************************************");


            foreach(int d in ll)
                Console.WriteLine(d+ " ");
            Console.WriteLine("****************************************");
            Console.ReadLine();

        }
    }
}
