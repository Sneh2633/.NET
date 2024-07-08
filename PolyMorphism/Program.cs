namespace PolyMorphism
{
   
    class Ex27
    {
        public virtual void disp()
        {
            Console.WriteLine("Hi from Ex27 Class");
        }
    }

    class Ex28 : Ex27
    {
        public override void disp()
        {
           base.disp();
            Console.WriteLine("Hi from Ex28 Class");
        }
        static void Main4(string[] args)
        {
            Ex28 obj = new Ex28();
            Ex27 obj1= new Ex28();
            obj.disp();

            obj1.disp();

            Console.ReadKey();
        }
    }
}
