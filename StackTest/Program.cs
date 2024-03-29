﻿// create arrays of doubles ant ints
using StackTest;

double[] doubleElements = { 1.1, 2.2, 3.3, 4.4, 5.5, 6.6 };
int[] intElements = { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 , 11 };

StackTest.Stack<double> doubleStack = new(5); // stack stores doubles
StackTest.Stack<int> intStack = new(10); // stack of ints

TestPushDouble(); // push double onto doubleStack
TestPopDouble(); // pop double onto doubleStack
TestPushInt(); // push int onto intStack
TestPopInt(); // pop int onto intStack

Console.WriteLine("---------------------------Generic Stack Test--------------------------");

// push doubles onto doubleStack
TestPush(nameof(doubleStack), doubleStack, doubleElements);
// pop doubles from doubleStack
TestPop(nameof(doubleStack), doubleStack, doubleElements);
// push int onto intStack
TestPush(nameof(intStack), intStack, intElements);
// pop int from intStack
TestPop(nameof(intStack), intStack, intElements);

// test Push method
void TestPush<T>(string name, StackTest.Stack<T> stack, 
    IEnumerable<T> elements)
{
    try
    {
        // push elements onto stack
        Console.WriteLine($"\nPushing elements onto {name}");

        foreach (var element in elements)
        {
            Console.Write($"{element:F1} ");
            stack.Push(element); // push onto stack
        }
    }
    catch (FullStackException exception)
    {
        Console.Error.WriteLine($"\nMessage: {exception.Message}");
        Console.Error.WriteLine(exception.StackTrace);
    }
}

// test Pop method
void TestPop<T>(string name, StackTest.Stack<T> stack,
    IEnumerable<T> elements)
{
    try
    {
        // pop elements from stack
        Console.WriteLine($"\nPopping elements from {name}");

        T popValue; // store element removed from stack
                    // remove all elements from stack
        while (true)
        {
            popValue = stack.Pop(); // pop from intStack
            Console.Write($"{popValue} ");
        }
    }
    catch (EmptyStackException exception)
    {
        Console.Error.WriteLine($"\nMessage: {exception.Message}");
        Console.Error.WriteLine(exception.StackTrace);
    }
}


// test Pop method with doubleStack
void TestPushInt()
{
    try
    {
        // push elements onto stack
        Console.WriteLine("\nPushing elements onto intStack");

        foreach (var element in intElements)
        {
            Console.Write($"{element} ");
            intStack.Push(element); // push onto intStack
        }
    }
    catch (FullStackException exception)
    {
        Console.Error.WriteLine($"\nMessage: {exception.Message}");
        Console.Error.WriteLine(exception.StackTrace);
    }
}

// test Pop method with doubleStack
void TestPopInt()
{
    try
    {
        // pop elements onto stack
        Console.WriteLine("\nPopping elements onto intStack");

        int popValue; // store element removed from stack

        // remove all elements from stack
        while (true)
        {
            popValue = intStack.Pop(); // pop from intStack
            Console.Write($"{popValue} ");
        }
    }
    catch (EmptyStackException exception)
    {
        Console.Error.WriteLine($"\nMessage: {exception.Message}");
        Console.Error.WriteLine(exception.StackTrace);
    }
}

// test Pop method with doubleStack
void TestPopDouble()
{
    try
    {
        // pop elements onto stack
        Console.WriteLine("\nPopping elements onto doubleStack");

        double popValue; // store element removed from stack

        // remove all elements from stack
        while (true)
        {
            popValue = doubleStack.Pop(); // pop from doubleStack
            Console.Write($"{popValue:F1} ");
        }
    }
    catch (EmptyStackException exception)
    {
        Console.Error.WriteLine($"\nMessage: {exception.Message}");
        Console.Error.WriteLine(exception.StackTrace);
    }
}

// test Push method with doubleStack
void TestPushDouble()
{
    try
    {
        // push elements onto stack
        Console.WriteLine("\nPushing elements onto doubleStack");

        foreach (var element in doubleElements)
        {
            Console.Write($"{element:F1} ");
            doubleStack.Push(element); // push onto doubleStack
        }
    }
    catch (FullStackException exception)
    {
        Console.Error.WriteLine($"\nMessage: {exception.Message}");
        Console.Error.WriteLine(exception.StackTrace);
    }
}