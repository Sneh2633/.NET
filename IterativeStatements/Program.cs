internal class Program
{
    private static void Main(string[] args)
    {
        int input;
        System.Console.WriteLine("Enter a number:");
        input=int.Parse(Console.ReadLine());

        int i=1;
        while(i<=input){
            System.Console.WriteLine(i);
            i++;
        }
        System.Console.WriteLine("-------------------------------------------------------");

        i=1;
        do{
            System.Console.WriteLine(i);
            i++;
        }while(i<=input);

        System.Console.WriteLine("-------------------------------------------------------");

        for(int j=1;j<=10;j++){
            System.Console.WriteLine(j);
        }

        int[] arr=new int[]{1,2,3,4,5,6,7,8,9,10};

        foreach (int item in arr)
        {
            System.Console.Write(item+" ");
        }
    }
}