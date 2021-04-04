using System;

public class Stack
{
    private Element _last;
    public int Count { get; private set; }

    public Stack()
    {
        _last = null;
        Count = 0;
    }

    public void Push(int value)
    {
        var newElement = new Element
        {
            Previous = null,
            Value = value
        };

        if (Count == 0)
        {
            _last = newElement;
        }
        else
        {
            newElement.Previous = _last;
            _last = newElement;
        }
        Count++;

    }

    public int Pop()
    {
        var deletedValue = _last.Value;
        _last = _last.Previous;
        Count--;
        return deletedValue;
    }

    public int Peek()
    {
        var viewValue = _last.Value;
        return viewValue;
    }
}
