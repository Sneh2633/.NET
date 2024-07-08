using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LambdaExpressions
{
    class Student
    {
        public int Id { get; set; }
        public string Name { get; set; }
    }
    class StudDemo {
        static void Main(string[] args)
        {
            var s1 = new Student { Id = 10, Name = "Snehal" };
            var s2 = new Student { Id = 11, Name = "Akshay" };
            var s3 = new Student { Id = 12, Name = "Shubham" };
            var s4 = new Student { Id = 13, Name = "Rajveer" };

            IList<Student> slist= new List<Student>()
            {
                s1,s2,s3,s4 //collection initializer.
            };

            Console.WriteLine("total Students: {0}",slist.Count);

        }
    }

}
