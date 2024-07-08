using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Channels;
using System.Threading.Tasks;

namespace LambdaExpressions
{
    class ExtentionMethod
    {
        static void Main3(string[] args)
        {
        var items = new string[]{"1","2","3","4","5","6","7","8","9" };
        var evenNums=items.Filter(x=>x>5).Select(x=> $"Item no: {x}");

            Console.WriteLine($"Numbers: {string.Join(',',evenNums)}");
        }


    }
}
