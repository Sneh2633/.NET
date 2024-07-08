namespace CodingStandards
{
    //1.child class fields should not hide base class fields.
    public class Person
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }

        public Person() { }
        public Person(string firstName, string lastName)
        {
            FirstName = firstName;
            LastName = lastName;
        }
        public virtual string GetFullName()
        {
            return String.Format("{0} {1}", FirstName, LastName);
        }
    }
    public class Employee : Person
    {
        public string Role {  get; set; }

        public Employee(string firstName,string lastName,string role) : base(firstName,lastName) {
        Role= role;
        }

          public override string GetFullName()
          {
            return String.Format("Miss. {0} {1}", FirstName, LastName);
          }
    }
    class Program
    {
        static void Main1(string[] args)
        {
            Employee e=new Employee("Snehal","Bhogawade","Student");
            Console.WriteLine(e.GetFullName());
            

        }
    }
}
