using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections;

namespace MyNewProject1.Assigment_test_Pena4
{
    ////Write a asp.net Program to Print an Array List using a for-each loop
    class ArrayListP6
    {
        static void Main(string[] args)
        {
            ArrayList al = new ArrayList();
            al.Add(1);
            al.Add("Ram");
            al.Add(2);
            al.Add(3);
            al.Add("Siya");

            foreach (var v1 in al)
                Console.WriteLine(v1);
            Console.ReadLine();

        }
    }
}
