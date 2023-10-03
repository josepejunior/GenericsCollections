using System.Runtime.Serialization;

namespace StackTest
{
    [Serializable]
    public class EmptyStackException : Exception
    {
        // parameterless constructor
        public EmptyStackException()
        {
        }

        // one-parameter constructor
        public EmptyStackException(string? message) : base("Stack is empty")
        {
            // empty constructor
        }

        //two-parameter constructor
        public EmptyStackException(string? message, Exception? innerException) : base(message, innerException)
        {
            // empty constructor
        }

        protected EmptyStackException(SerializationInfo info, StreamingContext context) : base(info, context)
        {
            // empty constructor
        }
    }
}