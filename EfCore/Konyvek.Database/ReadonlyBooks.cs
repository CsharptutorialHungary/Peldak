using Konyvek.Cqrs;
using Konyvek.Database.Entities;
using Microsoft.EntityFrameworkCore;

namespace Konyvek.Database;

internal sealed class ReadonlyBooks : IReadOnlyBooks, IDisposable
{
    private readonly KonyvekContext _context;
    private bool _disposed;

    public ReadonlyBooks(KonyvekContext context)
    {
        _context = context;
    }

    public void Dispose()
    {
        if (!_disposed)
        {
            _disposed = true;
            _context.Dispose();
        }
    }

    public async IAsyncEnumerable<BookDto> GetBooks()
    {
        var books = _context.Books
            .Include(book => book.Publisher)
            .Include(book => book.Author)
            .AsAsyncEnumerable();

        await foreach (var book in books)
        {
            yield return new BookDto
            {
                ISBN = book.ISBN,
                PublishYear = book.PublishYear,
                Title = book.Title,
                AuthorName = $"{book.Author!.LastName}, {book.Author!.FirstName}",
                PublisherName = book.Publisher!.Name,
            };
        }
    }
}

internal class WritableBooks : IWritableBooks, IDisposable
{
    private readonly KonyvekContext _context;
    private bool _disposed;

    public WritableBooks(KonyvekContext context)
    {
        _context = context;
    }

    public void Dispose()
    {
        if (!_disposed)
        {
            _disposed = true;
            _context.Dispose();
        }
    }

    public async Task Write(WriteBookCommand writeBook)
    {
        var publisher = _context.Publishers
            .Where(p => p.Name == writeBook.PublisherName)
            .First();
        
        var author = _context.Authors
            .Where(a => a.FirstName == writeBook.AuthorFirstName 
                   && a.LastName == writeBook.AuthorLastName)
            .First();

        var book = new Book
        {
            Author = author,
            Publisher = publisher,
            PublishYear = writeBook.PublishYear,
            Title = writeBook.Title,
            ISBN = writeBook.Id,
        };

        await _context.SaveChangesAsync();
    }
}
