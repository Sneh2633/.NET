using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LambdaExpressions
{
    public static class StringArrExtension
    {
        public static IEnumerable<int> Filter(this IEnumerable<string>items,Func<int,bool>func) {
           return items.Select(i => Convert.ToInt32(i)).Where(i => func(i));
        } 
    }
}
