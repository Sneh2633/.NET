using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CollectionProject1
{
    internal class ShoppingCart
    {
        Stack<string> cart=new Stack<string>();
        Stack<string>redoStack=new Stack<string>();

        public void Add(string itemName)
        {
            cart.Push(itemName);
        }

        public void Undo() {
            var item=cart.Pop();
            redoStack.Push(item);
        }
        public void Redo()
        {
            var item=redoStack.Pop();
            cart.Push(item);
        }

        public void ViewCart()
        {
            foreach (var item in cart)
            {
                Console.WriteLine("\t" + item);

            }
        }
    }
}
