using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CollectionProject
{
    internal class Generics2
    {
        public void Add<T>(T a,T b)
        {
            dynamic d1 = a;
            dynamic d2 = b;
            Console.WriteLine(d1+d2);

        }
        public void Sub<T>(T a, T b)
        {
            dynamic d1 = a;
            dynamic d2 = b;
            Console.WriteLine(d1 - d2);
        }
        public void Mul<T>(T a, T b)
        {
            dynamic d1 = a;
            dynamic d2 = b;
            Console.WriteLine(d1 * d2);
        }
        public void Div<T>(T a, T b)
        {
            dynamic d1 = a;
            dynamic d2 = b;
            Console.WriteLine(d1 / d2);
        }
        static void Main(string[] args)
        {
            Generics2 g2= new Generics2();
            g2.Add<float>(5.5f, 6.5f);
            g2.Sub<int>(12, 5);
            g2.Div<double>(12.50, 5.10);
            g2.Mul<byte>(12, 5);

        }
    }
}
