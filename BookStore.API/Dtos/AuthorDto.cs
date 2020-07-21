using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace BookStore.API.Dtos
{
    public class AuthorDto
    {
        public int Id { get; set; }
        public string Firstname { get; set; }
        public string Lastname { get; set; }
        public string Bio { get; set; }
        public virtual IList<BookDto> Books { get; set; }
    }

    public class AuthorForCreateDto
    {
        [Required]
        public string Firstname { get; set; }
        [Required]
        public string Lastname { get; set; }
        public string Bio { get; set; }
    }

    public class AuthorForUpdateDto
    {
        public int Id { get; set; }
        public string Firstname { get; set; }
        public string Lastname { get; set; }
        public string Bio { get; set; }
    }

}