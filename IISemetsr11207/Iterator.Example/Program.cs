using Iterator.Example;

var library = new Library();
var librarian = library.CreateIterator();

while (!librarian.IsDone())
{
    Console.WriteLine($"Name of book: {librarian.CurrentItem.Name}");
    librarian.Next();
}

