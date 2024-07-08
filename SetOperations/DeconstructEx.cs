using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SetOperations
{
    
    
        internal class Book
        {
            int B_id { get; set; }
            string B_title { get; set; }
            double Price { get; set; }

            public Book()
            {
            }

            //Constructor..
            public Book(int id, string nm, double pz)
            {
                B_id = id;
                B_title = nm;
                Price = pz;
            }

            public void Deconstruct(out int bid, out string nm, out double pz)
            {
                bid = B_id;
                nm = B_title;
                pz = Price;
            }
            //Overload Deconstruct 
            public void Deconstruct(out int bid, out string nm)
            {
                bid = B_id;
                nm = B_title;
            }
        }

        internal class DeconstructEx
    {
            static void Main(string[] args)
            {
                Book b = new Book(1, "Life is Gift", 654);
                var (B_Id, B_Name, Price) = b;

                Console.WriteLine("Book Name : " + B_Name);

                var (_, _, bookPrice) = b;

                Console.WriteLine("Book Price : " + bookPrice);

                var (Id, _, _) = b;
                Console.WriteLine("Book Price : " + Id);
                Console.ReadLine();
            }
        }
    }
    
    

