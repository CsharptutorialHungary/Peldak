namespace Konyvek.Cqrs;

public interface IReadOnlyBooks
{
    IAsyncEnumerable<BookDto> GetBooks();
}
