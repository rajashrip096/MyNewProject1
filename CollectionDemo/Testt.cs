using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyNewProject1.CollectionDemo
{
    //Cutom Type Non-generic collection
    class SS<T>
    {
        private T obj;

        public T Obj { get => obj; set => obj = value; }
    }
    class S
    {
        private object obj;

        public object Obj { get => obj; set => obj = value; }
    }
    class Testt
    {
        static void Main(string[] args)
        {
            SS<float> s1 = new SS<float>();
            s1.Obj = 4.5f;
            float d = s1.Obj;//Type casting

            S s = new S();
            s.Obj = "Omkar";
            s.Obj = 9000;
            int x = (int)s.Obj;
                       
            Console.ReadLine();
        }
    }
}
