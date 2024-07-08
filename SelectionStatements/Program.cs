internal class Program
{
    private static void Main(string[] args)
    {
        /*
        System.Console.WriteLine("Enter the number: ");
        int no=int.Parse(Console.ReadLine());

        if(no>0){
            System.Console.WriteLine($"{no} is positive");
        }else if(no<0){
            System.Console.WriteLine($"{no} is negative");
        }else{
            System.Console.WriteLine($"{no} is zero");
        }

        char ch;
        System.Console.WriteLine("Enter your favourite subject option: ");

        ch=(char)Console.Read();

        if(ch=='e'||ch=='E'){
            System.Console.WriteLine("English");
        }else if(ch=='m'||ch=='M'){
            System.Console.WriteLine("Mathematics");
        }else if(ch=='s'||ch=='S'){
            System.Console.WriteLine("Science");
        }else if(ch=='h'||ch=='H'){
            System.Console.WriteLine("Hindi");
        }else{
            System.Console.WriteLine("Marathi");
        }*/

        //switch statements

        char ch;
        System.Console.WriteLine("Enter your favourite subject option: ");

        ch=(char)Console.Read();

        switch(ch){
            case 'e':
            {
                System.Console.WriteLine("English");
                break;
            }
            case 'm':
            {
                System.Console.WriteLine("Maths");
                break;
            }
            case 's':
            {
                System.Console.WriteLine("Science");
                break;
            }
            default:
            {
                System.Console.WriteLine("Marathi");
                break;

            }
        }
    }
}