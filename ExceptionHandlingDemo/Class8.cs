using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyNewProject1.ExceptionHandlingDemo
{
    //custom 
    class InvalidExperienceException :ApplicationException
    {

    }
    class Emp
    {
        string nm;
        int experience;
        public string Nm
        {
            set { this.nm = value; }
            get { return nm; }
        }
        public override string ToString()
        {
            return "Name : " +  nm  + " Experience :" + experience;
        }
        public int Experience
        {
            set
            {
                if (value < 0)
                    throw new InvalidExperienceException();
                else
                    this.experience = value;
            }
            get { return experience; }
        }
    }
    class Class8
    {
        static void Main(string[] args)
        {
            Emp e1 = new Emp();
            Console.WriteLine("Enter the name and Experience");
            e1.Nm = Console.ReadLine();
            try
            {
                e1.Experience = int.Parse(Console.ReadLine());
            }
            catch(Exception e)
            {
                Console.WriteLine("Experience cant be negative");
            }
            Console.WriteLine(e1);
            Console.ReadLine();
        }
    }
}
