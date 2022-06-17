using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyNewProject1.LoopDemo
{
    class GrossSalary
    {
        static void Main(string[] args)
        {
            double basic, hra, da,GrossSalary;

            Console.WriteLine("Enter the basic Salary");
            basic =Convert.ToDouble(Console.ReadLine());

            if(basic <=10000)
            {
                hra = basic* 0.2;
                da = basic * 0.8;
            }
            else if(basic<=20000)
            {
                hra = basic * 0.25;
                da =  basic * 0.90;
            }
            else //(basic>20000)
            {
                hra = basic * 0.30;
                da = basic * 0.95;
            }

            GrossSalary = basic + hra + da;
            Console.WriteLine("Gross salary is " + GrossSalary);
            Console.ReadLine();

        }
    }
}
