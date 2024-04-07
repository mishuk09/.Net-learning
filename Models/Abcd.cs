using Microsoft.Data.SqlClient;
using System.ComponentModel.DataAnnotations;

namespace Store.Models
{
    public class Abcd
    {
        [Key]
        public int UserId1 { get; set; }

        [Required(ErrorMessage = "Username is required")]
        public string UserName { get; set; }

        [Required(ErrorMessage = "Email is required")]
        [EmailAddress(ErrorMessage = "Invalid email address")]
        public string UserEmail { get; set; }

        [Required(ErrorMessage = "Password is required")]
        [DataType(DataType.Password)]
        public string UserPassword { get; set; }

        public string Course { get; set; }  
    }
}

