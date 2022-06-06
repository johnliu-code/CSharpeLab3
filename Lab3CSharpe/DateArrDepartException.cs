using System;
using System.Runtime.Serialization;

namespace Lab3CSharpe
{
    [Serializable]
    internal class DateArrDepartException : Exception
    {
        public DateArrDepartException()
        {
        }

        public DateArrDepartException(string message) : base(message)
        {
        }

        public DateArrDepartException(string message, Exception innerException) : base(message, innerException)
        {
        }

        protected DateArrDepartException(SerializationInfo info, StreamingContext context) : base(info, context)
        {
        }
    }
}