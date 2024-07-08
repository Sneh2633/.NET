using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SetOperations
{
    public class Student {
        public int StudentID {  get; set; }
        public string StudentName { get; set; }
        public int Age { get; set; }
        public int StandardID { get; set;}
    }
    public class Standard
    {
        public int StandardID {  get; set; }
        public string StandardName { get; set; }
    }
    class JoinOperators
    {
        static void Main2(string[] args)
        {
            IList<Student> studentList = new List<Student>()
            {
                new Student() { StudentID = 1, StudentName = "John", Age = 13, StandardID =3 },
                new Student() { StudentID = 2, StudentName = "Moin",  Age = 21, StandardID =1 },
                new Student() { StudentID = 3, StudentName = "Bill",  Age = 18, StandardID =2 },
                new Student() { StudentID = 4, StudentName = "Ram" , Age = 20, StandardID =3},
                new Student() { StudentID = 5, StudentName = "Ron" , Age = 15, StandardID = 1 }
            };

            IList<Standard> standardList = new List<Standard>()
            {
                new Standard(){ StandardID = 1, StandardName="Standard 1"},
                new Standard(){ StandardID = 2, StandardName="Standard 2"},
                new Standard(){ StandardID = 3, StandardName="Standard 3"}
            };


            var student = from s in studentList
                          join
                          sd in standardList
                          on s.StandardID equals sd.StandardID
                          select new
                          {
                              s.StudentID,
                              s.StudentName,
                              sd.StandardName
                          };
            foreach (var s in student)
            {
                Console.WriteLine($"{s.StudentID}  :  {s.StudentName} : {s.StandardName}");
            }


            Console.WriteLine("--------------------------------------");

            var Group = from sd in standardList
                        join
                        s in studentList
                        on sd.StandardID equals s.StandardID
                        into StudentGroup
                        select new
                        {
                            sd,
                            StudentGroup
                        };


            foreach (var group in Group)
            {
                Console.WriteLine($"{group.sd.StandardName}");
                foreach (var st in group.StudentGroup)
                {
                    Console.WriteLine($" {st.StudentID}  : {st.StudentName}");
                }

            }
            Console.ReadLine();

        }
    }
}
        
    

