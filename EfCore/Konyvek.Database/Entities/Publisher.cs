using Microsoft.EntityFrameworkCore;
using System.ComponentModel.DataAnnotations;

namespace Konyvek.Database.Entities
{
    internal class Publisher
    {
        public int Id { get; set; }
        public string Name { get; set; } = null!;
        public string Adress { get; set; } = null!;
        public List<Book>? Books { get; set; }
    }
}
