using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyNewProject1.AbstrctandInterface
{
    public interface IDrawable
    {
        void draw();
    }
    abstract class Shape
    {
        public abstract void Fill();
    }
    class Circle:Shape,IDrawable
    {
        public void draw()
        {
            Console.WriteLine("draw circle");
        }
        public override void Fill()
        {
            {
                Console.WriteLine("Red colour is fill the circle ");
            }
        }
    }
    class AbstractionDemo3
    {
        static void Main(string[] args)
        {
            Circle c = new Circle();
            c.draw();
            c.Fill();
            Console.ReadLine();
        }
    }
}
