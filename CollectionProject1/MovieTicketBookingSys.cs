using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CollectionProject1
{
    class Customer
    {
        public string Name { get; set; }
        public int Age { get; set; }
    }
    class MovieTicketBookingSys
    {
            Queue<Customer> _queue;

            public MovieTicketBookingSys()
            {
                _queue = new Queue<Customer>();
            }

            public void AddToQueue(Customer c)
            {
                _queue.Enqueue(c);
                Thread.Sleep(1000);
                Console.WriteLine($"Added to queue: {c.Name}");
            }

            public void ProcessBoooking()
            {
                if(_queue.Any())
                {
                    var customer=_queue.Dequeue();  
                    Thread.Sleep(1000);
                    Console.WriteLine($"Processed booking for: {customer.Name}");
                }
            }

            public void ShowQueue()
            {
                Console.WriteLine("\n\tCurrent queue");
                Console.WriteLine("\t-------------------");

                foreach (var customer in _queue)
                {
                    Thread.Sleep(1000);
                    Console.WriteLine("\t"+customer.Name);
                }
            }
    }

    class Program1
    {
        static void Main6(string[] args)
        {
            MovieTicketBookingSys mb=new MovieTicketBookingSys();
            mb.AddToQueue(new Customer { Name="John", Age = 20});
            mb.AddToQueue(new Customer {Name="Martin",Age=9 });
            mb.AddToQueue(new Customer { Name = "Sam", Age = 25 });

            //Console.ReadKey();
            mb.ShowQueue();

            //Console.ReadKey();
            Console.WriteLine("\nBooking process started...");
            mb.ProcessBoooking();
            mb.ProcessBoooking();

            //Console.ReadKey();
            mb.ShowQueue();

           // Console.ReadKey();
            Console.WriteLine("Adding more customers to the queue");
            mb.AddToQueue(new Customer { Name = "Juli", Age = 16 });
            mb.AddToQueue(new Customer { Name = "Cristin", Age = 8 });

            //Console.ReadKey();
            mb.ShowQueue();

            //Console.ReadKey();
            Console.WriteLine("\nBooking process started...");
            mb.ProcessBoooking();
            mb.ProcessBoooking();

            //Console.ReadKey();
            mb.ShowQueue();

            Console.ReadLine();
        }
    }
}
