using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization.Formatters.Binary;
using System.Text;
using System.Threading.Tasks;

namespace FileHandling
{
    //.net 8 doesn't support binaryFormatter. 
    [Serializable]
    public class Employee
    {
        public int Id { get; set; }
        public string Name { get; set; }
    }

    class Program1
    {
        static void Main4(string[] args)
        {
            Employee emp=new Employee()
            {
                Id = 101,
                Name="Snehal"
            };

            string path = "E:\\.NET LTI\\file3.txt";

            FileStream fs = new FileStream(path, FileMode.Open, FileAccess.Write);
            /*
            BinaryFormatter bf = new BinaryFormatter();
            bf.Serialize(fs, emp);

            fs.Close();

            FileStream fs2 = new FileStream(path, FileMode.Open, FileAccess.Read);
            BinaryFormatter bf1 = new BinaryFormatter();
            Employee newemp = bf1.Deserialize(fs2) as Employee;
            fs2.Close();

            Console.WriteLine($"Id : {newemp.Id}  Name : {newemp.Name}");
            */
        }
    }
}
