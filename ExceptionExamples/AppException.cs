using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExceptionExamples
{
    class AppException
    {
        static void Main2(string[] args)
        {
            try
            {
                Console.WriteLine("Enter 1st no: ");
                int x = int.Parse(Console.ReadLine());
                Console.WriteLine("Enter 2nd no: ");
                int y = int.Parse(Console.ReadLine());
                if (y % 2 != 0)
                {
                    //throw new ApplicationException("Divisor value cannot be odd no");
                    throw new DivideByOddNoException();
                }
                int divide = x / y;
                Console.WriteLine("Result=" + divide);
            }
            catch (DivideByZeroException e)
            {
                Console.WriteLine(e.Message);
            }
            catch (FormatException)
            {
                Console.WriteLine("Input must be numeric value");
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
            finally
            {
                Console.WriteLine("End");
            }
        }
    }
}
