namespace ConsoleApp1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*
            Console.WriteLine("enter a no to print table:");
            int no=Convert.ToInt32(Console.ReadLine());

            for(int i=1;i<=10;i++)
            {
                Console.WriteLine($"{no} * {i} = {no * i}");
            }
            Console.ReadKey();
            */

            int[] arr=new int[] { 1, 2, 3, 4 };


            for(int i=0;i<arr.Length;i++)
            {
                Console.WriteLine(arr[i]);
            }
            Console.WriteLine("End");

        }
    }
}
