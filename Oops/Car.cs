using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyNewProject1.Oops
{
    class Car
    {
        public int modelno;
        public string carname;
        public string carcolour;
        int prize;
        static void Main(string[] args)
        {
            Car c1= new Car();
            c1.modelno = 12367;
            c1.carname = "suzuki";
            c1.carcolour = "blue";
            c1.prize = 50000;

            Car c2 = new Car();
            c2.modelno = 45263;
            c2.carname = "maruti";
            c2.carcolour = "red";
            c2.prize = 8690278;

            Car c3 = new Car();
            c3.modelno = 87836;
            c3.carname = "Audi";
            c3.carcolour = "grey";
            c3.prize = 63729;
            Console.WriteLine(c1.modelno+" "+c1.carname+" "+c1.carcolour);

            
            Console.WriteLine(c2.modelno+" "+c2.carname+" "+c2.carcolour);
            Console.WriteLine(c3.modelno+" "+c3.carname+" "+c3.carcolour);
            Console.ReadLine();
        }
    }
}
