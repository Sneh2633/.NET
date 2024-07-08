using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CollectionProject1
{
    class DictionaryGeneric
    {
        static void Main8(string[] args)
        {
            Dictionary<string,object> dict = new Dictionary<string,object>();

            dict.Add("Eid", "101");
            dict.Add("Ename", "Snehal");
            dict.Add("Job", "Manager");
            dict.Add("Salary", "250000.00");
            dict.Add("Phone", "908765432");
            dict.Add("Email", "Snehal@gmail.com");
            dict.Add("Dname", "Sales");
            dict.Add("Location", "Pune");

            foreach (string key in dict.Keys)
            {
                Console.WriteLine(key+" : " + dict[key]);
            }
        }
    }
}
