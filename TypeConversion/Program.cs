namespace TypeConversion
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Console.WriteLine("Hello, World!");

            /*int a = 5;
            int b = 3;

            float c;
            c = a * b;

            Console.WriteLine("Product of {0} and {1} is {2}",a,b,c);*/

            object str = "HP";
            string str1=str as string; //as->converts
            /*
            if(str is string)  //is-> compares
            {
                Console.WriteLine("It is num");
            }*/
            Console.WriteLine(str1);

        }
    }
}
