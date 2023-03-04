namespace Iterator.Example;

public interface IIterator<out T>
{
    T CurrentItem { get; }
    T First();
    T? Next();
    bool IsDone();
}