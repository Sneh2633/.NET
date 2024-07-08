using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Delegates
{
    public delegate void GetDel(double w, double h);
    public class MultiCastDelegates
    {
        static void Main2(string[] args)
        {
            Rectangle r= new Rectangle();
            GetDel g=new GetDel(r.GetArea);
            //GetDwl g=r.GetArea; -->binding method with delegate reference.
            g += r.GetPerimeter;
            g.Invoke(12.34, 56.78);

            g.Invoke(5.56, 7.78);
           // r.GetArea(12.34, 56.78);
            //r.GetPerimeter(12.34, 56.78);
        }
    }
    public class Rectangle
    {
        public void GetArea(double width,double height)
        {
            Console.WriteLine($"Area of Rectangle = {width*height}");
        }
        public void GetPerimeter(double width,double height)
        {
            Console.WriteLine($"Perimeter of rectangle = {2*(width+height)}");
        }
    }
}
