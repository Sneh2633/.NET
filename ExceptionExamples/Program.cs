namespace ExceptionExamples
{
    internal class Program
    {
        static void Main1(string[] args)
        {

            try
            {
                Console.WriteLine("Enter 1st no: ");
                int x=int.Parse(Console.ReadLine());
                Console.WriteLine("Enter 2nd no: ");
                int y=int.Parse(Console.ReadLine());
                int divide = x / y;
                Console.WriteLine("Result="+divide);
            }
            catch (DivideByZeroException e)
            {
                Console.WriteLine(e.Message);
            }
            catch (FormatException )
            {
                Console.WriteLine("Input must be numeric value");
            }
            catch(Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
            Console.WriteLine("End");
        }
    }
}
