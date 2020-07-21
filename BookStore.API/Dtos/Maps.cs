using BookStore.API.Models;
using AutoMapper;

namespace BookStore.API.Dtos
{
    public class Maps : Profile
    {
        public Maps()
        {
            CreateMap<Author, AuthorForUpdateDto>().ReverseMap();
            CreateMap<Author, AuthorForCreateDto>().ReverseMap();
            CreateMap<Author, AuthorDto>().ReverseMap();
            CreateMap<Book, BookDto>().ReverseMap();        
        }
    }
}