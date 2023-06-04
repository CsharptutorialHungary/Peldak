using Microsoft.EntityFrameworkCore;
using System.ComponentModel.DataAnnotations;

namespace Konyvek.Database.Entities
{
    internal class Book
    {
        public int ISBN { get; set; }
        public string Title { get; set; } = null!;
        public int PublishYear { get; set; }
        public Author? Author { get; set; }
        public Publisher? Publisher { get; set; }
    }
}
