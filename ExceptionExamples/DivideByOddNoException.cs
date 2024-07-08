using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExceptionExamples
{
    class DivideByOddNoException : ApplicationException
    {
        /*
        string msg;

        public DivideByOddNoException()
        {
            msg = "Attempted to divide by odd no";
        }

        public DivideByOddNoException(string msg)
        {
            this.msg = msg;
        }
        */

        public override string Message
        {
            get { return "Attempted to divide by odd no"; }
        }
        
    }
}
