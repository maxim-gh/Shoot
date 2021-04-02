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
        _first = null;
        _last = null;
        Count = 0;
    }

    public void Enqueue(int value)
    {
        var newElement = new Counter
        {
            Previous = null,
            Value = value
        };

        if (Count == 0)
        {
            _first = newElement;
            _last = _first;
            Count++;
        }
        else
        {
            _last.Previous = newElement;
            _last = newElement;
            Count++;
        }
    }
    public int Dequeue(int value)
    {
        var deletedValue = _first.Value;
        _first = _first.Previous;
        Count--;
        return deletedValue;
    }
    public int Peek(int value)
    {
        var deletedValue = _first.Value;
        return deletedValue;

    }
}