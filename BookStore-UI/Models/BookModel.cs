using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace BookStore_UI.Models
{
    public class Book
    {       
        public int Id { get; set; }
        [Required]
        public string Title { get; set; }
        [Required]
        public string ISBN { get; set; }
        public int? Year { get; set; }
        [StringLength(500)]
        public string Summary { get; set; }
        public string Image { get; set; }
        public decimal? Price { get; set; }
        [Required]
        public int AuthorId { get; set; }
        public virtual Author author { get; set; }
    }
}