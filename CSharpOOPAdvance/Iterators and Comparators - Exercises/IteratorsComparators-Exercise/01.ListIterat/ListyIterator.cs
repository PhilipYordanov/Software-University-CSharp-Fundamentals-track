using System;
using System.Collections.Generic;

public class ListyIterator<T>
{
    public int CurrentIndex { get; private set; }
    private IList<T> dataList;

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

    public void Print()
    {
        if (this.dataList.Count == 0)
        {
            Console.WriteLine("Invalid Operation!");
        }
        else
        {
            Console.WriteLine(this.dataList[CurrentIndex]);
        }
    }
}