using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;

namespace Test1505
{
    class MyIndexOutOfRangeException : ApplicationException
    {
        public MyIndexOutOfRangeException()
        {
        }

        public MyIndexOutOfRangeException(string message) : base(message)
        {
        }

        public MyIndexOutOfRangeException(string message, Exception innerException) : base(message, innerException)
        {
        }

        protected MyIndexOutOfRangeException(SerializationInfo info, StreamingContext context) : base(info, context)
        {
        }
    }
}
