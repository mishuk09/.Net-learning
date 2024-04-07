using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using store.models;

namespace Store.Models
{
    [Table("Book")]
    public class Book
    {
        public int Id { get; set; }

        [Required]
        
        [MaxLength(40)]
        public string ? BookName { get; set; }

        public int GenreId { get; set; }
        public Genre Genre;
    }
}
