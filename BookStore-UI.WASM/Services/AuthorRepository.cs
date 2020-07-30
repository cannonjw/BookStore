using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Threading.Tasks;
using Blazored.LocalStorage;
using BookStore_UI.WASM.Contracts;
using BookStore_UI.WASM.Models;

namespace BookStore_UI.WASM.Services
{
    public class AuthorRepository : BaseRepository<Author>, IAuthorRepository
    {
        private readonly HttpClient _client;
        private readonly ILocalStorageService _localStorage;
        public AuthorRepository(HttpClient client, ILocalStorageService localStorage) : base(client, localStorage)
        {
            _localStorage = localStorage;
            _client = client;
        }
    }
}