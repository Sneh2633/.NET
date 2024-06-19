internal class Program
{
    private static void Main(string[] args)
    {
        //Console.WriteLine("Hello, World!");
        string[] weekdays=new string[]{
            "Sunday","Monday","Tuesday","Wednesday","Thursday","Friday","Saturday"
        };

        foreach (var item in weekdays)
        {
            System.Console.WriteLine(item);
        }

        int length=weekdays.Length;
        System.Console.WriteLine($"length of the array is: {length}");
    }
}