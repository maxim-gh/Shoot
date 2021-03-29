using System;
using System.Runtime.ExceptionServices;
using System.Threading;

public class Queue
{
    private Counter _first;
    private Counter _last;
    public int Count { get; private set; }
    public Queue()
    {
        _first = new Counter
        {
            Value = 1,
            Next = _last
        };
        Count = 1;
    }

    public Counter GetElement(int index)
    {
        var current = _last;
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
            Next = _last,
            Value = value
        };
        _last = newElement;
        Count++;
    }
    public void Dequeue(int value)
    {
        _first.Next = _first;
        Count--;
    }
    public void Peek()
    {

    }
}