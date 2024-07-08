using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Intrinsics.Arm;
using System.Runtime.Intrinsics.X86;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace CollectionProject1
{
    public class Student : IComparable<Student>
    {
        public int Sid {  get; set; }
        public string Name { get; set; }
        public int Class {  get; set; }

        public float Marks {  get; set; }

        public int CompareTo(Student? other)
        {
            if (this.Sid > other.Sid) { return 1; }
            else if (this.Sid < other.Sid) return -1;   
            else
            {
                if (this.Name.Equals(other.Name))
                { 
                    return 0; 
                }
                else 
                { 
                    return 1;
                }
                
            }
        }
    }
    public class CompareStudent : IComparer<Student>
    {
        public int Compare(Student? x, Student? y)
        {
            if (x.Marks < y.Marks)
            {
                return 1;
            }else if(x.Marks > y.Marks)
            {
                return -1;
            }
            else
            {
                return 0;
            }
        }
    }
    class TestStudent
    {
        static void Main(string[] args)
        {
            Student s1 = new Student { Sid = 5, Name = "Snehal", Class = 16, Marks = 94.60f };
            Student s2 = new Student { Sid = 2, Name = "Dhanashri", Class = 15, Marks = 94.60f };
            Student s3 = new Student { Sid = 2, Name = "Shubham", Class = 16, Marks = 93.75f };
            Student s4 = new Student { Sid = 1, Name = "Akshay", Class = 16, Marks = 90.12f };
            Student s5 = new Student { Sid = 3, Name = "Veeru", Class = 16, Marks = 97.60f };


            List<Student> list = new List<Student>() { s1, s2, s3, s4, s5 };

            //list.Reverse();
            CompareStudent cs= new CompareStudent();
            list.Sort(cs);


            foreach (Student s in list)
            {
                Console.WriteLine(s.Sid+"\t"+s.Name+"\t"+s.Class+"\t"+s.Marks);
            }
        }
       
    }
}
