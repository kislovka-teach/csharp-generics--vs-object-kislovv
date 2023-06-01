namespace Iterator.Example;

public class BookIterator: IIterator<Book>
{
    private Aggregate<Book> _aggregate;
    private int _currentIndex;
    public Book CurrentItem { get; private set; }
    public Book First()
    {
        return _aggregate[0];
    }

    public Book? Next()
    {
        _currentIndex += 1;
        if (IsDone()) return null;
        
        CurrentItem = _aggregate[_currentIndex];
        return CurrentItem;
    }

    public bool IsDone()
    {
        return _aggregate.Count == _currentIndex;
    }

    public BookIterator(Aggregate<Book> aggregate)
    {
        _aggregate = aggregate;
        CurrentItem = First();
    }
}