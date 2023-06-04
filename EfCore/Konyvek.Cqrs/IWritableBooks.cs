namespace Konyvek.Cqrs;

public interface IWritableBooks
{
    Task Write(WriteBookCommand writeBook);
}
