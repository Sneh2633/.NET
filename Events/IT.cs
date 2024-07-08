using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Events
{
    public class IT
    {
        private readonly EmployeeSeparator employeeSeparator;
        public IT(EmployeeSeparator empsep)
        {
            employeeSeparator = empsep;
            empsep.EmpSeparated += EmployeeSeparatorEventHandler;
        }

        public void EmployeeSeparatorEventHandler(object? sender, EmpEventArgs e)
        {
            Console.WriteLine("IT dept: employee separation process related to IT."+e.Name);
        }
    }
}
