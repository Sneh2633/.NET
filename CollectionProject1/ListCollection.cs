using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CollectionProject1
{
    class ListCollection
    {
        static void Main7(string[] args)
        {
            List<int> list = new List<int>(10);

            list.Add(1);
            list.Add(2);
            list.Add(3);
            list.Add(4);
            list.Add(5);

            Console.WriteLine(list.Capacity);
            for (int i = 0; i < list.Count; i++)
            {
                Console.Write(list[i]+" ");
            }
            Console.WriteLine();
            list.Insert(5, 7);

            foreach (int item in list)
            {
                Console.Write(item+" ");

            }
        }
    }
}
