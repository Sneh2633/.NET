using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace Events
{
    public class EmpEventArgs
    {
        public int Eid {  get; set; }
        public string Name { get; set; }

    }
    public class EmployeeSeparator
    {
       // public delegate void EmployeeSeparatorEventHandler();
        public event EventHandler<EmpEventArgs> EmpSeparated;
        public void Separate()
        {
            EmpEventArgs empEventArgs = new EmpEventArgs { Eid = 123, Name = "Snehal" };
            if(EmpSeparated != null)
            {
                EmpSeparated(this , empEventArgs);
            }
            //EmpSeparated?.Invoke();
        }
    }
    class EventDemo {
        static void Main(string[] args)
        {
            EmployeeSeparator e = new EmployeeSeparator();
            Finance f=new Finance(e);

            //EmployeeSeparator e1= new EmployeeSeparator();
            IT i=new IT(e);
            e.Separate();

            Console.ReadKey();        }
    }


}
