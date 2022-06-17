using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyNewProject1.Oops
{
    class StudentProperty
    {
        int id;
        string name;
        float perc;
        bool place;

        public int Id
        {
            get;
            set;
        }
        public string Name
        {
            get;
            set;
        }
        public float Perc
        {
            get { return perc; }
            set { perc = value; }
        }
       public bool Place
        {
            get { return place; }
            set { place = value; }
        }
        static void Main(string[] args)
        {
            StudentProperty s = new StudentProperty();
            s.Id = 10;
            s.Name = "reshma";
            s.Perc = 80;
            s.Place = true;
            Console.WriteLine(s.Id + " " + s.Name + " " + s.Perc + " " + s.Place);
            Console.ReadLine();

        }  
    }
}
