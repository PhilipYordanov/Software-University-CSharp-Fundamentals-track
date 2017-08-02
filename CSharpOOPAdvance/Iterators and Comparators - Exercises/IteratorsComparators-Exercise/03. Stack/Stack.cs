using System;
using System.Collections;
using System.Collections.Generic;

public class Stack<T>  : IEnumerable<T>
{
    public IList<T> data { get; private set; }

    public Stack()
    {
        this.data = new List<T>();
    }

    public void Push(params T[] items)
    {
        foreach (var item in items)
        {
            this.data.Add(item);
        }
    }

    public T Pop()
    {
        if (this.data.Count == 0)
        {
            throw new InvalidOperationException("No elements");
        }

        var item = this.data[this.data.Count - 1];
        this.data.RemoveAt(this.data.Count - 1);
        return item;
    }

    public IEnumerator<T> GetEnumerator()
    {
        for (int i = this.data.Count - 1; i >= 0; i--)
        {
            yield return this.data[i];
        }
    }

    IEnumerator IEnumerable.GetEnumerator()
    {
        return this.GetEnumerator();
    }
}