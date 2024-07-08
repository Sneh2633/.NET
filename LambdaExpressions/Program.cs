namespace LambdaExpressions
{
    public delegate string GreetingDel(string name);    
    class Program
    {
        /*
        public string SayHello(string name)
        {
            return "Hello " + name+" a very good morning!";
        }
        */
        static void Main1(string[] args)
        {
            //Console.WriteLine("Hello, World!");
            Program p=new Program();
            //anonymous method
            // GreetingDel gd = delegate (string name) { return "Hello " + name + " a very good morning!"; };
            GreetingDel gd = (name) =>
            {
                return "Hello " + name;
            };
            string res=gd.Invoke("Snehal");
            Console.WriteLine(res);
        }
    }
}
