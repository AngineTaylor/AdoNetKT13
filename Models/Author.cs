using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace LibrarySystem.Models
{
    public class Author
    {
        [Key]
        public int Id { get; set; }

        [Required]
        [MaxLength(100)]
        public string Name { get; set; }

        // Навигационное свойство
        public ICollection<Book> Books { get; set; } = new List<Book>();
    }
}