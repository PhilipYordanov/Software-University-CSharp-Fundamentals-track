public class Box<T>
{
    public T data { get; set; }

    public Box(T data)
    {
        this.data = data;
    }

    public override string ToString()
    {
        return $"{this.data.GetType().FullName}: {this.data}";
    }
}