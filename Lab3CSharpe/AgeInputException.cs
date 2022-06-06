using System;
using System.Runtime.Serialization;

namespace Lab3CSharpe
{
    [Serializable]
    internal class AgeInputException : Exception
    {
        public AgeInputException()
        {
        }

        public AgeInputException(string message) : base(message)
        {
        }

        public AgeInputException(string message, Exception innerException) : base(message, innerException)
        {
        }

        protected AgeInputException(SerializationInfo info, StreamingContext context) : base(info, context)
        {
        }
    }
}