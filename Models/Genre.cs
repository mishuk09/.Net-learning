using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using Store.Models;

namespace store.models
{
    
    
        [Table("genre")]
         public class Genre
    { 
        
            public int Id { get; set; }

        [Required]

        [MaxLength(40)]
        public string GenreName { get; set; }
        public List<Book> Books { get; set; }
    }

}
