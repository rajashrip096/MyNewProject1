using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyNewProject1.AbstrctandInterface
{
    public interface IPrintable
    {
        void run();
    }
    public interface IMoveable
    {
        //public static int x = 80;
        int x
        {
            get;
            set;
        }
        void show(int x);
        /*static void move()
        {
            Console.WriteLine("Move");
        }
        internal void foo()
        {
            Console.WriteLine(":foo...");
        }*/
    }
    class InterfaceDemo: IMoveable, IPrintable
    {
            int IMoveable.x
            {
                get;
                set;

            }
        public void show(int x)
        {
            Console.WriteLine("show method" +" "+x);
        }
        public void run()
        {
            Console.WriteLine("run......");
        }
        static void Main(string[] args)
        {
            IMoveable m = new InterfaceDemo();
             
                m.show(200);

                /*IMoveable.move();
                m.foo();*/
                IPrintable p = new InterfaceDemo();
                p.run();
            Console.ReadLine();
        }
    }
}
