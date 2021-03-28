using System;
using System.Runtime.ExceptionServices;
using System.Threading;

public class Queue
{
    private Counter _first;
    public int Count { get; private set; }
    public Queue()
    {
        _first = new Counter
        {
            Value = 1,
            Next = null
        };
        Count = 2;
    }
    public Counter GetElement(int index)
    {
        var current = _first;
        for (var i = 1; i <= index; i++)
        {
            current = current.Next;
        }
        return current;
    }
    public void Enqueue(int value)
    {
        var newElement = new Counter
        {
            Next = null,
            Value = value
        };
        _first = newElement;
        Count++;
    }
    public void Dequeue()
    {

    }
    public void Peek()
    {

    }
}