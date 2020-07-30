using Blazored.LocalStorage;
using BookStore_UI.WASM.Contracts;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Net.Http.Json;
using System.Text;
using System.Threading.Tasks;

namespace BookStore_UI.WASM.Services
{
    public class BaseRepository<T> : IBaseRepository<T> where T : class
    {
        private readonly HttpClient _client;
        private readonly ILocalStorageService _localStorage;

        public BaseRepository(HttpClient client, ILocalStorageService  localStorage)
        {
            _client = client;
            _localStorage = localStorage;
        }
        public async Task<bool> Create(string url, T obj)
        {
            _client.DefaultRequestHeaders.Authorization = new System.Net.Http.Headers.AuthenticationHeaderValue("bearer", await GetBearerToken());
            var response = await _client.PostAsJsonAsync<T>(url, obj);

            if (response.StatusCode == HttpStatusCode.Created)
                return true;

            return false;
        }

        public async Task<bool> Delete(string url, int id)
        {
            if (id < 1)
                return false;
            _client.DefaultRequestHeaders.Authorization = new System.Net.Http.Headers.AuthenticationHeaderValue("bearer", await GetBearerToken());
            var response = await _client.DeleteAsync(url + id);

            if (response.StatusCode == HttpStatusCode.NoContent)
                return true;

            return false;

        }

        public async Task<T> Get(string url, int id)
        {
            if (id < 1)
                return null;
            _client.DefaultRequestHeaders.Authorization = new System.Net.Http.Headers.AuthenticationHeaderValue("bearer", await GetBearerToken());
            var response = await _client.GetFromJsonAsync<T>(url + id);

            return response;
        }

        public async Task<IList<T>> Get(string url)
        {
            _client.DefaultRequestHeaders.Authorization = new System.Net.Http.Headers.AuthenticationHeaderValue("bearer", await GetBearerToken());
            var response = await _client.GetFromJsonAsync<IList<T>>(url);

            return response;
        }

        public async Task<bool> Update(string url, T obj, int Id)
        {
            if (obj == null)
                return true;
            _client.DefaultRequestHeaders.Authorization = new System.Net.Http.Headers.AuthenticationHeaderValue("bearer", await GetBearerToken());

            var response = await _client.PutAsJsonAsync(url+Id,obj);

            if (response.StatusCode == HttpStatusCode.Created || response.StatusCode == HttpStatusCode.NoContent)
                return true;

            return false;
        }

        private async Task<string> GetBearerToken()
        {
            return await _localStorage.GetItemAsync<string>("authToken");
        }
    }
}