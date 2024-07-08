using System;

delegate void OrderEventHandler();

class Ex50_Event//order
{
    public event OrderEventHandler OnCreated;

    public void Create()
    {
        Console.WriteLine("Order created");

        if (OnCreated != null)
        {
            OnCreated();
        }
    }
}


class Email// mail
{
    public static void Send()
    {
        Console.WriteLine($"Send an email");
        Console.ReadKey();
    }
}

class SMS //msg
{
    public static void Send()
    {
        Console.WriteLine($"Send an SMS");
        Console.ReadKey();
    }
}

class Program
{
    static void Main1(string[] args)
    {
        var order = new Ex50_Event();

        order.OnCreated += Email.Send;
        order.OnCreated += SMS.Send;

        order.Create();
    }
}