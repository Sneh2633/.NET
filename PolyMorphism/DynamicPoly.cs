using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PolyMorphism
{
    abstract class Shape
    {
        public abstract void CalcArea();
    }
    class Rectangle : Shape
    {
        double len;
        double breadth;
        public Rectangle(double len, double breadth)
        {
            this.len = len;
            this.breadth = breadth;
        }
        
        public override void CalcArea()
        {
            Console.WriteLine($"Area of Rectangle = {len*breadth}");
        }
    }
    class Circle : Shape
    {
        float pi = 3.1415f;
        public float rad {  get; set; }

        public override void CalcArea()
        {
            Console.WriteLine($"Area of circle = {pi*rad*rad}");
        }
    }
    internal class DynamicPoly
    {

        static void Main5(string[] args)
        {
            Circle c1 = new Circle();
            c1.rad = 5.5f;
            c1.CalcArea();

            Rectangle r=new Rectangle(5.5,5.5);
            r.CalcArea();

        }
    }
}
