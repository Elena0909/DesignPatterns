namespace ProxyPattern;

public interface IBookRepository
{
    Book? GetBookById(int id);
    void InsertBook(Book book);

    void RemoveBookById(int id);    
}
