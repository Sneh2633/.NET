namespace CollectionProject
{
    internal class Program
    {
        static void Main1(string[] args)
        {
            Generics1 g = new Generics1();
            //bool res = g.Compare(20, 20);
            bool res=g.Compare<double>(12.45,56.43);    //it will internally box and unbox data type without giving any error.
            Console.WriteLine(res);
            bool res1 = g.Compare<int>(12, 12);    //it will internally box and unbox data type without giving any error.
            Console.WriteLine(res1);
        }
    }

    class Generics1
    {
        /*
        public bool Compare(int a,int b)
        {
            if(a == b) return true;
            return false;
        }
        */   //need to create many methods as the data type changes.Solution to this is:

        /*
        public bool Compare(Object x, Object y)  //if datatype is object it is not type safe. it will compare the any type of data.
        {
            if (x.Equals(y))
            {
                return true;
            }
            return false;
        }
        */
        public bool Compare<T>(T x, T y)
        {
            if(x.Equals(y)) return true;
            return false;
        }

    }
}
