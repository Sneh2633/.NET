using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Events
{
    public class Finance
    {
        private readonly EmployeeSeparator employeeSeparator;

        public Finance(EmployeeSeparator employeeSeparator)
        {
            this.employeeSeparator = employeeSeparator;
            employeeSeparator.EmpSeparated += EmployeeSeparatorEventHandler;
        }

        public void EmployeeSeparatorEventHandler(object? sender, EmpEventArgs e)
        {
            Console.WriteLine("finance dept: employee separation process related to finance"+e.Name);
        }

       // public delegate void EventHandler(object? sender, EventArgs e);
    }
}
