using System;
class Ex23_Base
{
    public string name="Snehal";
    public int Id = 5;
    public void displayParentClassDetails()
    {
        Console.WriteLine($"I am {name}");
        Console.WriteLine($"ID : {Id}");
        
    }
}
class Ex23_Child : Ex23_Base
{
    public void getIdFromParentClass()
    {
        base.displayParentClassDetails();
        Console.WriteLine($"This is my ID : {Id}");
        
    }
}
class Ex24_Child : Ex23_Base
{
    public void getDetailsFromParentClass()
    {
        base.displayParentClassDetails();
        Console.WriteLine("I am from 2nd derived class");
    }
}
class Program
{
    static void Main(string[] args)
    {
        Ex23_Child c1= new Ex23_Child();
        Ex24_Child child = new Ex24_Child();
        c1.getIdFromParentClass();
        child.getDetailsFromParentClass();
    }
}