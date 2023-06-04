namespace Konyvek.Cqrs;

public class BookDto
{
    public int ISBN { get; set; }
    public string Title { get; set; }
    public int PublishYear { get; set; }
    public string AuthorName { get; set; }
    public string PublisherName { get; set; }

    public BookDto() 
    {
        Title = string.Empty;
        PublisherName = string.Empty;
        AuthorName = string.Empty;
    }
}
