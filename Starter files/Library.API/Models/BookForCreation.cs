using System.ComponentModel.DataAnnotations;

namespace Library.API.Models
{
    public class BookForCreation
    {         
        [Required]
        public string Title { get; set; }
     
        [Required]
        public string Description { get; set; }
    }
}
