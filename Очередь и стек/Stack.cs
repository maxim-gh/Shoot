using System;

public class Stack
{
    private Counter _last;
    public int Count { get; private set; }

    public Stack()
    {
        _last = null;
        Count = 0;
    }

    public void Push(int value)
    {
        var newElement = new Counter
        {
            Previous = null,
            Value = value
        };

        if (Count == 0)
        {
            _last = newElement;
            Count++;
        }
        else
        {
            newElement.Previous = _last;
            _last = newElement;
            Count++;
        }

    }

    public int Pop(int value)
    {
        var deletedValue = _last.Value;
        _last = _last.Previous;
        Count--;
        return deletedValue;
    }

    public int Peek(int value)
    {
        var deletedValue = _last.Value;
        return deletedValue;
    }
}
