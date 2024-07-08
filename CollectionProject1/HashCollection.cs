using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CollectionProject1
{
    internal class HashCollection
    {
        static void Main2(string[] args)
        {
            Hashtable ht = new Hashtable();
            ht.Add("Eid", "101");
            ht.Add("Ename", "Snehal");
            ht.Add("Job", "Manager");
            ht.Add("Salary", "250000.00");
            ht.Add("Phone", "908765432");
            ht.Add("Email", "Snehal@gmail.com");
            ht.Add("Dname", "Sales");
            ht.Add("Location", "Pune");

            foreach (object value in ht.Values)
            {
                Console.WriteLine(value);
            }

            Console.WriteLine(ht["Email"]);

            Console.WriteLine("Hello".GetHashCode());
        }
    }
}
