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
    public class AuthorRepository : IAuthorRepository
    {
        private ApplicationDbContext _context;
        public AuthorRepository(ApplicationDbContext context)
        {
            _context = context;
        }

        public ApplicationDbContext Context { get; }

        public async Task<bool> Create(Author entity)
        {
            await _context.Authors.AddAsync(entity);
            return await Save();
        }

        public async Task<bool> Delete(Author entity)
        {
            _context.Authors.Remove(entity);
            return await Save();
        }

        public async Task<IList<Author>> FindAll()
        {
            var authors = await _context.Authors.ToListAsync<Author>();
            return authors;
        }

        public async Task<Author> FindById(int id)
        {
            var author = await _context.Authors.FirstOrDefaultAsync(x => x.Id == id);
            return author;
        }

        public async Task<bool> isExist(int id)
        {
            return await _context.Authors.AnyAsync(q => q.Id == id);
        }

        public async Task<bool> Save()
        {
            var changes = await _context.SaveChangesAsync();
            return changes > 0;
        }

        public async Task<bool> Update(Author entity)
        {
            _context.Authors.Update(entity);
            return await Save();

        }
    }
}