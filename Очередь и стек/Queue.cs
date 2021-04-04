using System;
using System.Runtime.ExceptionServices;
using System.Threading;

public class Queue
{
    private Element _first;
    private Element _last;
    public int Count { get; private set; }
    public Queue()
    {
        _first = null;
        _last = null;
        Count = 0;
    }

    public void Enqueue(int value)
    {
        var newElement = new Element
        {
            Previous = null,
            Value = value
        };

        if (Count == 0)
        {
            _first = newElement;
            _last = _first;
        }
        else
        {
            _last.Previous = newElement;
            _last = newElement;
        }
        Count++;
    }
    public int Dequeue()
    {
        var deletedValue = _first.Value;
        _first = _first.Previous;
        Count--;
        return deletedValue;
    }
    public int Peek() 
    {
        var viewValue = _first.Value;
        return viewValue;

    }
}