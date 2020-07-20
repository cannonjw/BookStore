using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using BookStore.API.Contracts;
using BookStore.API.Data;
using BookStore.API.Models;
using Microsoft.EntityFrameworkCore;

namespace BookStore.API.Services
{
    public class BookRepository : IBookRepository
    {
        private readonly ApplicationDbContext _context;
        public BookRepository(ApplicationDbContext context)
        {
            _context = context;

        }
        public async Task<bool> Create(Book entity)
        {
            await _context.Books.AddAsync(entity);
            return await Save();
        }

        public async Task<bool> Delete(Book entity)
        {
            _context.Books.Remove(entity);
            return await Save();
        }

        public async Task<IList<Book>> FindAll()
        {
            var books = _context.Books.ToListAsync<Book>();
            return await books;
        }

        public async Task<Book> FindById(int id)
        {
            var book = _context.Books.FirstOrDefaultAsync(x => x.Id == id);
            return await book;
        }

        public async Task<bool> Save()
        {
            var result = await _context.SaveChangesAsync();
            return result > 0;
        }

        public async Task<bool> Update(Book entity)
        {
            _context.Books.Update(entity);
            return await Save();

        }
    }
}