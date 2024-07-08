using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SetOperations
{
    
        internal class TupleEx
        {
            //1. use a tuple in a method
            static void PrintData(Tuple<string, string, int> tupleAuthor)
            {
                Console.WriteLine("Author:{0}, Title:{1}, Year:{2}.", tupleAuthor.Item1, tupleAuthor.Item2, tupleAuthor.Item3);
            }

            //2. return tuples by method
            static Tuple<string, string, int> PrintData2()
            {
                return new Tuple<string, string, int>("Neha", "Life is Gift", 560);
            }

            //3. 
            static (string name, string title, long year) TupleReturnLiteral()
            {
                string name = "Mahesh Chand";
                string title = "ADO.NET Programming";
                long year = 2003;

                // tutle literal
                return (name, title, year);
            }


            static void Main0(string[] args)
            {
                //var author = new Tuple<string, int>("Kumar", 129);
                //Console.WriteLine(author.Item1);


                ////1. use a tuple in a method
                PrintData(new Tuple<string, string, int>("Neha", "Life is Gift", 560));
                Console.ReadLine();


                ////2. return tuples by method
                //var author3 = PrintData2();
                //Console.WriteLine($"Author : {author3.Item1}, Title:{author3.Item2}" +
                //    $", Year:{author3.Item3}");
                //Console.ReadLine();

                ////3. tuple return type
                var author5 = TupleReturnLiteral();
                Console.WriteLine($"Author {author5.name} {author5.title} {author5.year} ");
                Console.ReadLine();


            }
        }
    }

