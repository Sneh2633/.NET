using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Delegates
{
    /*
    public delegate double delegate1(int x, float y, double z);
    public delegate void delegate2(int x, float y, double z);
    public delegate bool delegate3(string s);
    */
    class GenericDelegate
    {
        /*
        public static double AddNums1(int x,float y,double z)
        {
            return x + y + z;
        }

        public static void AddNums2(int x,float y,double z)
        {
            Console.WriteLine(x+y+z);
        }
        public static bool checkLength(string str)
        {
            if (str.Length > 5)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
        */
        static void Main3(string[] args)
        {
            /*
            Func<int,float,double,double> d1 = AddNums1;
            double res = d1.Invoke(100, 34.5f, 193.465);
            Console.WriteLine(res);  


            Action<int,float,double> d2 = AddNums2;
            d2.Invoke(100, 34.5f, 193.465);

            Predicate<string> d3 = checkLength;
            bool status = d3.Invoke("Bhogawade");
            Console.WriteLine(status); 
            */

            Func<int, float, double, double> obj1 = (x, y, z) =>
            {
                return x + y + z;
            };
            obj1.Invoke(100, 34.5f, 193.465);

            Action<int, float, double> obj2 = (x, y, z) =>
            {
                Console.WriteLine(x+y+z);
            };
            //double res=obj2.Invoke(100, 34.5f, 193.465);

            Predicate<string> obj3 = (s) =>
            {
                if (s.Length > 5)
                {
                    return true;
                }
                else
                {
                    return false;
                }
            };
            obj3.Invoke("Bhogawade");

        }
    }
}
