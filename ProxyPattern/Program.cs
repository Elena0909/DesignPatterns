// See https://aka.ms/new-console-template for more information
using ProxyPattern;

Console.WriteLine("----- Proxy Pattern -----");
//Remote/Virtual/Security proxy

IBookRepository repository = new BookCachedRepository(new BookRepository());

var book = repository.GetBookById(101);
var book1 = repository.GetBookById(101);
var book2 = repository.GetBookById(101);