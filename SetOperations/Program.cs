using System.Xml.Schema;

namespace SetOperations
{
    internal class Program
    {
        static void Main1(string[] args)
        {
            List<int> list = new List<int>() { 10, 10, 34, 89, 23, 90, 34, 45, 23, 34 };
            List<int> numbers = new List<int>() { 10, 88, 34, 89, 90, 20, 90, 34, 40, 23, 34 };


            var num = list.Distinct().ToList();

            foreach (int i in num) {
                Console.WriteLine(i);
            }

            Console.WriteLine("--------------------------------------");
            var num2 = (from n in list
                        select n).Except(numbers).ToList();

            foreach (int i in num2) {
                Console.WriteLine(i);
            }

            Console.WriteLine("--------------------------------------");

            var num3 = (from n in list
                        select n).Intersect(numbers).ToList();

            foreach (int i in num3) {
                Console.WriteLine(i);
            }

            Console.WriteLine("--------------------------------------");

            var num4 = (from nums in list
                        select nums).Union(numbers).ToList();

            foreach (int i in num4)
            {
                Console.WriteLine(i);
            }

            Console.WriteLine("--------------------------------------");

            var num5 = (from n in list
                        orderby n descending
                        select n).Take(2);

            foreach
                (int i in num5)
            {
                Console.WriteLine(i);
            }


            Console.WriteLine("--------------------------------------");

            var num6 = (from n in list
                        orderby n ascending
                        select n).TakeWhile(x => x > 50);

            foreach (int i in num6)
            {
                Console.WriteLine(i);
            }

            Console.WriteLine("--------------------------------------");

            List<string> str = new List<string>() { "Snehal", "Pooja", "Nikita", "Gauri", "Akki", "Prati", "Sayali" };

            var names = str.TakeWhile(s => s.StartsWith("S")).ToList();

            foreach (var s in names)
            {
                Console.WriteLine(s);
            }
            Console.WriteLine("--------------------------------------");

            var names1 = (from n in str
                          select n).Skip(2).ToList();

            foreach (var s in names1)
            {
                Console.WriteLine(s);
            }

            Console.WriteLine("--------------------------------------");
            var names2 = (from n in str
                          select n).SkipLast(2).ToList();

            foreach (var s in names2)
            {
                Console.WriteLine(s);
            }

        }
    }
}
