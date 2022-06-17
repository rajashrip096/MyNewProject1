using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyNewProject1.Oops
{
    //write the code to show uses of this keyword in single code.
    class ThisKeyword
    {
        int y;
        public ThisKeyword(int y)
        {
            this.y = y;
            this.show();
        }
        public ThisKeyword():this(90)
        {
            Console.WriteLine("Constructor");
            Console.ReadLine();
        }
        public void show()
        {
            Console.WriteLine(y);
            Console.ReadLine();
        }
        static void Main(string[] args)
        {
            ThisKeyword t = new ThisKeyword();
            //t.show();
        }
        
    }
}
