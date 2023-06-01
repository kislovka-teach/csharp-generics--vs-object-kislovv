namespace Iterator.Example;

public class Library : Aggregate<Book>
{
    private Book[] _books;
    public Library()
    {
        _books = new Book[]
        {
            new Book
            {
                Author = "J.K.Rowling",
                CreationYear = 1990,
                Genre = "Fantasy",
                Name = "Harry Potter"
            },
            new Book
            {
                Author = "Dostoevsky",
                CreationYear = 1890,
                Genre = "Detective",
                Name = "Crime and Punishment"
            },
            new Book
            {
                Author = "Tolstoy",
                CreationYear = 1869,
                Genre = "Novel",
                Name = "War and Peace"
            }
        };
    }

    public override Book this[int index]
    {
        get => _books[index];
        set => _books[index] = value;
    }

    public override int Count => _books.Length;

    public override IIterator<Book> CreateIterator()
    {
        return new BookIterator(this);
    }
}