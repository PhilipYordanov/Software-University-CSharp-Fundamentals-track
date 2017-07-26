using System;

public class Scale<T>
    where T : IComparable<T>
{
    private readonly T _first;
    private readonly T _second;

    public Scale(T first, T second)
    {
        this._first = first;
        this._second = second;
    }

    public T GetHavier()
    {
        var result = this._first.CompareTo(this._second);

        if (result == 0)
        {
            return default(T);
        }
        if (result > 0)
        {
            return this._first;
        }
        return this._second;
        //return result > 0 ? this._first : this._second;
    }
}