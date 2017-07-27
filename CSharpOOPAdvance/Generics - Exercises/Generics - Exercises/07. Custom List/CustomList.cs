using System;
using System.Collections.Generic;
using System.Linq;

public class CustomList<T>
    where T : IComparable<T>
{
    private readonly IList<T> _data;

    public CustomList()
    {
        this._data = new List<T>();
    }

    public void Add(T item)
    {
        this._data.Add(item);
    }

    public T Remove(int index)
    {
        T item = this._data[index];
        this._data.RemoveAt(index);
        return item;
    }

    public bool Contains(T item)
    {
        return this._data.Contains(item);
    }

    public void Swap(int index1, int index2)
    {
        var firstElement = this._data[index1];
        var secondElement = this._data[index2];
        this._data[index1] = secondElement;
        this._data[index2] = firstElement;
    }

    public int CountGreaterThan(T item)
    {
        return this._data.Count(t => t.CompareTo(item) == 1);
    }

    public T Max()
    {
        return this._data.Max();
    }

    public T Min()
    {
        return this._data.Min();
    }

    public IList<T> GetList()
    {
        return this._data;
    }

    public void ForEach()
    {
        foreach (var item in this._data)
        {
            Console.WriteLine(item);
        }
    }
}