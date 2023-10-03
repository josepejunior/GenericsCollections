using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StackTest
{
    public class Stack<T>
    {
        private int top; // location of the top element
        private T[] elements; // array that stores stack elements

        // parameterless constructor creates a stack of the default size
        public Stack() : this(10)
        {
            // empty constructor; calls constructor at line 21 to perform initialize
        }

        // Constructor creates a stack of the specified number of elements
        public Stack(int stackSize)
        {
            if (stackSize <= 0)
            {
                throw new ArgumentException("Stack size must be positive.");
            }
            elements = new T[stackSize];
            top = -1; // stack initially empty
        }

        // push element onto the atack; if unsuccessfull, throw FullStackException
        public void Push(T pushValue)
        {
            if (top == elements.Length - 1)
            {
                throw new FullStackException($"Stack is full, cannot push {pushValue}");
            }
            ++top;
            elements[top] = pushValue;
        }

        //return the top element if not empty, else throw EmptyStackException
        public T Pop()
        {
            if (top == -1)
            {
                throw new EmptyStackException("Stack is empty, cannot pop");
            }
        }
    }
}
