using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;

namespace ExceptionExamples
{
    public class CustomExceptionss
    {
        static void Main4(string[] args)
        {
            try
            {
                throw new UserAlreadyLoggedInException("User is logged in - no duplicate session allowed");
            }
            catch (UserAlreadyLoggedInException ex)
            {
                Console.WriteLine(ex.Message);
            }
        }
    }
    public class UserAlreadyLoggedInException : Exception
    {
        public UserAlreadyLoggedInException() : base() { }
        public UserAlreadyLoggedInException(string message) : base(message)
        {

        }
        public UserAlreadyLoggedInException(string message, Exception innerException) : base(message, innerException)
        {

        }
        public UserAlreadyLoggedInException(SerializationInfo info, StreamingContext context) : base(info, context) { }
    }

}
