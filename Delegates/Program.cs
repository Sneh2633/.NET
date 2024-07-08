
/*namespace Delegates
{
    public delegate void AddDelegate(int a, int b);
    public delegate string SayDelegate(string str);

    public class Program
    {
        public void AddNums(int a, int b)
        {
            Console.WriteLine(a+b);
        }
        public static string SayHello(string name)
        {
            return "Hello " + name;
        }
        static void Main1(string[] args)
        {
            Program p= new Program();
            AddDelegate ad=new AddDelegate(p.AddNums);
            //ad(100, 50);
            ad.Invoke(50, 70);

            SayDelegate sd = new SayDelegate(SayHello);
            string str = sd.Invoke("Snehal");  //sd("snehal");
            Console.WriteLine(str);
        }
    }
}
*/

using System;

public class Ex49_PredicateDelegate
{

   
    static void Main(string[] args)
    {

        //expression lambda :-
        Predicate<string> isUpper = (str) => str.Equals(str.ToUpper());
        bool s = isUpper("SNEHAL!!");
        //statement lambda:-
        Predicate<string> isUpper1 = (string str) => { 
            return str.Equals(str.ToUpper()); 
         }; 
         
        Console.WriteLine(s);
        Console.ReadKey();
    }
}