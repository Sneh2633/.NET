namespace LinqQuery
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<int>l = new List<int>() { 1,2,3,4,5,6,7,8,9,10};
            
            var querySyntax=from obj in l
                            where obj>2
                            select obj;

            foreach (var item in querySyntax)
            {
                Console.WriteLine(item);
            }

            Console.WriteLine("-----------------------------------------");
            var methodSyntax = l.Where(obj => obj > 2);

            foreach (var i in methodSyntax)
            {
                Console.WriteLine(i);
            }

            Console.WriteLine("-----------------------------------------");

            var mixedSyntax = (from obj in l
                               select obj).Max();

            Console.WriteLine("max value = "+mixedSyntax);
            ;
        }
    }
}
