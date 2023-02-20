namespace Iterator.Example;

public abstract class Aggregate<T>
{
    public abstract T this[int index] { get; set; }
    public abstract int Count { get; }
    public abstract IIterator<T> CreateIterator();
}