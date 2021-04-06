using System;
using System.ComponentModel;
using Microsoft.VisualBasic.FileIO;

public class Tree
{
    private Element _current;
    private Element _first;
    public int Count { get; private set; }

    public Tree()
    {
        _current = null;
        Count = 0;
    }
    public void AddElement(int value)
    {
        var newElement = new Element {
            Right = null,
            Left = null,
            Counter = 0,
            Value = value
        };
        var d = true;
        if (Count == 0)
        {
            _current = newElement;
            _first = _current;
        }
        else
        {
            while (d)
            {
                if (_current.Value < newElement.Value)
                {
                    if (_current.Right == null)
                    {
                        _current.Right = newElement;
                        _current = _current.Right;
                        d = false;
                    }
                    else
                    {
                        _current = _current.Right;
                    }
                }
                if (_current.Value > newElement.Value)
                {  
                    if (_current.Left == null)
                    {
                        _current.Left = newElement;
                        _current = _current.Left;
                        d = false;
                    }
                    else
                    {
                        _current = _current.Left;
                    }
                }
                if (_current.Value == newElement.Value & Count != 0)
                {
                    _current.Counter++;
                    d = false;
                }
            }
        }
        Count++;
        _current = _first;
    }

    public void Search(int value, out bool checkElement, out int counter)
    {
        checkElement = true;
        counter = 0;
        var d = true;
        while (d)
        {
            if (value > _current.Value)
            {
                if (_current.Right == null)
                {
                    checkElement = false;
                    d = false;
                }
                else
                {
                    _current = _current.Right;
                }
            }
            if (value < _current.Value)
            {
                if (_current.Left == null)
                {
                    checkElement = false;
                    d = false;
                }
                else
                {
                    _current = _current.Left;
                }
            }
            if (value == _current.Value)
            {
                counter = _current.Counter;
                d = false;
            }
        }
    }
}
