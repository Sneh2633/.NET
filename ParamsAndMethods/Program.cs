using System.Security.Cryptography.X509Certificates;

namespace ParamsAndMethods
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*
            int[] arr= {11,12,13,14,15};
            int res=Add(arr);
            Console.WriteLine(res);

            //public static float pi = 3.14f;
            Console.WriteLine(Ex.pi);

            Console.WriteLine("enter a no: ");
            int no=int.Parse(Console.ReadLine());
            int cube = Ex.cube(no);
            Console.WriteLine(cube);
            */
            Person p = new Person();
            p.Name = "Test";
            Console.WriteLine(p.Name);

        }
        /*public static int Add(params int[] Numbers)
        {
            int sum = 0;

            foreach (int i in Numbers)
            {
                sum += i;
            }
            return sum;
        }*/
    }
    class Ex {
        /*
        public static float pi = 3.14f;

        public static int cube(int n)
        {
            return n * n * n;
        }
        */
    }
    class Person
    {
        private string name;
        

        public string Name
        {
            get{ return name; }
            set{ name = value; }
        }
    
        /*
        public override string ToString()
        {
            return name;
        }*/

    }

}
