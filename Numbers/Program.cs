// See https://aka.ms/new-console-template for more information
namespace Numbers
{
    class Program
    {
        static void Main(string[] args)
        {
            int i=10;
            int m=sizeof(int);
            Console.WriteLine(i);
            System.Console.WriteLine($"size of int is: {m}");

           System.Console.WriteLine("Enter an integer: ");
            int j=int.Parse(Console.ReadLine());
            System.Console.WriteLine(j); 

            short s=100;
            long l=10000;
            uint u=23;
            System.Console.WriteLine($"Short: {s},long:{l},unsigned int:{u}");

            int num=(int)l;
            short num1=(short)i;

            System.Console.WriteLine(num);
            System.Console.WriteLine(num1);

            float f=87.5f;
            double d=123.785;
            decimal dd=345.80m;

            System.Console.WriteLine(f);
            System.Console.WriteLine(d);
            System.Console.WriteLine(dd);

            bool b;
            b=false;
            System.Console.WriteLine(b);

    System.Console.WriteLine("Enter a string input: ");
           b=bool.Parse(Console.ReadLine());
           System.Console.WriteLine(b);
        }
    }
}
