using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodingStandards
{
    //2)User integer values for Enumerations when possible.

    class Enumerations
    {
        static void Main2(string[] args)
        {
            Console.WriteLine(Weekdays.Thursday);


        }
        
    }
    public enum Weekdays
    {
        Monday=1,
        Tuesday=2,
        Wednesday=3,
        Thursday=4,
        Friday=5,
        Saturday=6,
        Sunday=7
    }
}
