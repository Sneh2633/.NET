using System;

namespace myapp
{
    internal class Program
    {
        /*
        static void Main(string[] args)
        {

            Student s1= new Student();
            Staff st1= new Staff();
            Console.WriteLine(s1);
            Console.WriteLine(st1);

            Student s=new Student("Snehal",23);
        Staff st=new Staff("Ankush",60,"Peon");
            Console.WriteLine(s);
            Console.WriteLine(st);

            Console.WriteLine(Student.fee);
        }*/
    }

    internal class Staff
    {
        string? name;
        int age;
        string? department;

        public Staff() {
            Console.WriteLine("In default Constructor");
            name = default;
            age = default;
            department =default;
        }
        public Staff(string name, int age, string department)
        {
            this.name=name;
            this.age=age;
            this.department=department;
        }

        public override string ToString()
        {
            return $"Name: {name}, Age: {age}, Department: {department}";
        }

    }

    internal class Student
    {
        string name;
        int rollno;
        //public const int MaxEnrolledCourses = 3; //can't change in constructor.
        public readonly int MaxEnrolledCourses=3; //we can reassign value in the constructor 
        public static int fee=1000;

        public Student() {
            name = "NA";
            rollno = 0;
            int totalcourses = 6;
            MaxEnrolledCourses = totalcourses;
        }
        public Student(string name, int rollno) { 
            this.name = name;
            this.rollno = rollno;
        }

        public override string ToString()
        {
            return $"Name: {name}, Roll No: {rollno}";
        }
    }
}