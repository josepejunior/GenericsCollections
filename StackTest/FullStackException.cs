using System.Runtime.Serialization;

namespace StackTest
{
    [Serializable]
    public class FullStackException : Exception
    {
        // parameterless constructor
        public FullStackException()
        {
        }

        // one-parameter constructor
        public FullStackException(string? message) : base("Stack is full")
        {
            // empty constructor
        }

        //two-parameter constructor
        public FullStackException(string? message, Exception? innerException) : base(message, innerException)
        {
            // empty constructor
        }

        protected FullStackException(SerializationInfo info, StreamingContext context) : base(info, context)
        {
            // empty constructor
        }
    }
}