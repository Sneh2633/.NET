using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CollectionProject1
{
    class Customer1
    {
        public int CustId
        {
            get; set;   
        }
        public string Name { get; set; }
        public string City { get; set; }
        public double Balance {  get; set; }
    }
    class TestCust {
        static void Main9(string[] args)
        {
            List<Customer1>l=new List<Customer1>();
            Customer1 c1=new Customer1 { CustId=101,Name="Scott",City="Hyderabad",Balance=25000.00};
            Customer1 c2 = new Customer1 { CustId = 102, Name = "Smith", City = "Banglore", Balance = 55000.00 };
            Customer1 c3 = new Customer1 { CustId = 103, Name = "Dave", City = "Delhi", Balance = 30000.00 };
            Customer1 c4 = new Customer1 { CustId = 104, Name = "Martin", City = "Mumbai", Balance = 60000.00 };

            l.Add(c1);
            l.Add(c2);
            l.Add(c3);
            l.Add(c4);

            // l.AddRange();

            foreach (Customer1 cust in l)
            {
                Console.WriteLine(cust.CustId+" "+cust.Name+" "+cust.City+" "+cust.Balance);
            }


        }
    }

}
