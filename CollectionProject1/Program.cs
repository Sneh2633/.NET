using System.Collections;
namespace CollectionProject1
{
    internal class Program
    {
        static void Main1(string[] args)
        {
            ArrayList al = new ArrayList(10);
            al.Add(10);
            al.Add(20);
            al.Add(30);
            al.Add(40);
            al.Add(50);

            Console.WriteLine(al.Capacity);

            foreach (object obj in al)
            {
                Console.Write(obj + " ");
                
            }
            al.Insert(3, 353);
            Console.WriteLine();
            foreach (object o in al)
                {
                    Console.Write(o+" ");
                }
            Console.WriteLine();
            al.Remove(10);
            al.RemoveAt(2);

            foreach (object item in al)
            {
                Console.Write(item+" ");
            }


        }
    }
}
