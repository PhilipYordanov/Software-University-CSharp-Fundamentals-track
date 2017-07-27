using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;

public class ListyIterator<T> : IEnumerable<T>
{
    private const string ExceptionMessage = "Invalid Operation!";
    public int CurrentIndex { get; private set; }
    private readonly IList<T> dataList;

    public ListyIterator(params T[] items)
    {
        this.CurrentIndex = 0;
        this.dataList = new List<T>(items);
    }

    public bool Move()
    {
        if (this.CurrentIndex < this.dataList.Count - 1)
        {
            ++this.CurrentIndex;
            return true;
        }
        return false;
    }

    public bool HasNext()
    {
        if (this.CurrentIndex < this.dataList.Count - 1)
        {
            return true;
        }
        return false;
    }

    public string Print()
    {
        return this.dataList.Count == 0
            ? throw new InvalidOperationException(ExceptionMessage)
            : $"{this.dataList[this.CurrentIndex]}";
    }

    public string PrintAll()
    {
        //return this.dataList.Count == 0
        //    ? throw new InvalidOperationException(ExceptionMessage)
        //    : $"{string.Join(" ", this.dataList)}";
      
        var sb = new StringBuilder();
        foreach (var item in this.dataList)
        {
            sb.Append($"{item} ");
        }
        return sb.ToString().Trim();
    }

    public IEnumerator<T> GetEnumerator()
    {
        for (int i = 0; i < this.dataList.Count ; i++)
        {
            yield return this.dataList[i];
        }
    }

    IEnumerator IEnumerable.GetEnumerator()
    {
        return this.GetEnumerator();
    }
}