namespace ProxyPattern;

public class BookCachedRepository : IBookRepository
{
    private readonly BookRepository _dbRepository;
    private readonly Dictionary<int, Book> _cache;

    public BookCachedRepository(BookRepository dbRepository)
    {
        _dbRepository = dbRepository;
        _cache = new Dictionary<int, Book>();
    }
    public Book? GetBookById(int id)
    {
        Book? book = null;

        _cache.TryGetValue(id, out book);

        if (book == null)
        {
            book = _dbRepository.GetBookById(id);
            if(book != null)
                _cache.Add(id, book);
        }
        else Console.WriteLine("Book extracted from cache");

        return book;
    }

    public void InsertBook(Book book)
    {
        _dbRepository.InsertBook(book);
        _cache.Add(book.Id, book);
    }

    public void RemoveBookById(int id)
    {
        _dbRepository.RemoveBookById(id);
        _cache.Remove(id);
    }
}
