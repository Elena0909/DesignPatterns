namespace ProxyPattern;

public class BookRepository : IBookRepository
{
    private readonly List<Book> _dbBooks = new List<Book>()
    {
        new Book(231, "Book1", "AuthorA"),
        new Book(101, "Book2", "AuthorB"),
        new Book(340, "Book3", "AuthorC")

    };
    public Book? GetBookById(int id)
    {
        Console.WriteLine("Getting book ID");
        Thread.Sleep(2000);
        return _dbBooks.FirstOrDefault(book => book.Id == id);
    }

    public void InsertBook(Book book)
    {
        Console.WriteLine("Inserting book");
        Thread.Sleep(2000);
        _dbBooks.Add(book);
    }

    public void RemoveBookById(int id)
    {
        Console.WriteLine("Removing book");
        Thread.Sleep(2000);
        var book = _dbBooks.FirstOrDefault(x=> x.Id == id);
        if (book != null)
        {
            _dbBooks.Remove(book);
        }
    }
}
