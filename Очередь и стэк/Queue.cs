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
            Next = null
        };
        Count = 1;
    }

    private Counter GetElement(int index)
    {
        var current = _first;
        for (var i = 1; i <= index; i++)
        {
            current = current.Next;
        }
        return current;
    }

    public int Get(int index)
    {
        return GetElement(index).Value;
    }
    public void Enqueue(int value)
    {
        var newElement = new Counter
        {
            Next = _first,
            Value = value
        };
        _first = newElement;
        Count++;
    }
    public void Dequeue(int value)
    {
        var delElement = new Counter
        {
            Next = null,
            Value = value
        };
        var end = GetElement(Count);
        end = delElement;
        Count--;

    }
    public void Peek()
    {

    }
}