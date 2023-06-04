namespace Konyvek.Cqrs;

public class WriteBookCommand : ICommand
{
    public string Title { get; set; }
    public int PublishYear { get; set; }
    public string AuthorFirstName { get; set; }
    public string AuthorLastName { get; set; }
    public string PublisherName { get; set; }
    public int Id { get; set; }

    public WriteBookCommand()
    {
        Title = string.Empty;
        PublisherName = string.Empty;
        AuthorLastName = string.Empty;
        AuthorFirstName = string.Empty;
    }
}
