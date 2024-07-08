using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CollectionProject1
{
    internal class StackCollection
    {
        private static ShoppingCart cart;
        static void Main5(string[] args)
        {
            /*
            Stack<string> st=new Stack<string>();

            st.Push("a");
            st.Push("b");
            st.Push("c");
            st.Push("d");

            var poppedItem=st.Pop();

            var peekvalue=st.Peek();
            */

            int option = 0;
            cart = new ShoppingCart();
            while(option!= 5)
            {
                Console.WriteLine("\n\n\tMenu - select an option");
                Console.WriteLine("\t\t----------------------------");
                Console.WriteLine("\t\t1.Add an item to shopping cart");
                Console.WriteLine("\t\t2. Undo");
                Console.WriteLine("\t\t3. Redo");
                Console.WriteLine("\t\t4. View Cart");
                Console.WriteLine("\t\t5. Exit");
                option=int.Parse(Console.ReadLine());
                Console.Write("Option: ");

                switch(option)
                {
                    case 1:
                        bool repeat = true;
                        while (repeat)
                        {
                            Console.Write("enter item name(type'n' to stop): " );
                            var itemName=Console.ReadLine();

                            if(itemName != "n")
                            {
                                cart.Add(itemName);
                            }
                            repeat = itemName == "n" ? false : true;
                        }
                        ShowCartItems();
                        break;

                        case 2:
                        cart.Undo();
                        ShowCartItems();
                        break;

                        case 3:
                        cart.Redo();
                        ShowCartItems();
                        break;

                        case 4:
                        ShowCartItems();
                        break;

                        case 5: 
                        Environment.Exit(0);
                        break;

                    default:
                        Console.WriteLine("Invalid Option");
                        break;
                }
            }

        }

        private static void ShowCartItems()
        {
            throw new NotImplementedException();
        }
    }
}
