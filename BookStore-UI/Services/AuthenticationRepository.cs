
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;
using Blazored.LocalStorage;
using BookStore_UI.Contracts;
using BookStore_UI.Models;
using BookStore_UI.Providers;
using BookStore_UI.Static;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Components.Authorization;
using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;

namespace BookStore_UI.Services
{
    public class AuthenticationRepository : IAuthenticationRepository
    {
        private readonly IHttpClientFactory _client;
        private readonly ILocalStorageService _localStorage;
        private readonly ApiAuthenticationStateProvider _authenticationStateProvider;
        public AuthenticationRepository(IHttpClientFactory client, ILocalStorageService localStorage, ApiAuthenticationStateProvider authenticationStateProvider)
        {
            _authenticationStateProvider = authenticationStateProvider;
            _localStorage = localStorage;
            _client = client;

        }

        public async Task<bool> Login(LoginModel model)
        {
            var request = new HttpRequestMessage(HttpMethod.Post, Endpoints.LoginEndpoint);
            request.Content = new StringContent(JsonConvert.SerializeObject(model), Encoding.UTF8, "application/json");

            var client = _client.CreateClient();
            HttpResponseMessage response = await client.SendAsync(request);

            if (!response.IsSuccessStatusCode)
            {
                return false;
            }

            var content = await response.Content.ReadAsStringAsync();
            var token = JsonConvert.DeserializeObject<TokenResponse>(content);

            await _localStorage.SetItemAsync("authToken", token.Token);

            await _authenticationStateProvider.LoggedIn();
            client.DefaultRequestHeaders.Authorization = new System.Net.Http.Headers.AuthenticationHeaderValue("bearer", token.Token);
            
            return true;
        }

        public async Task Logout()
        {
            await _localStorage.RemoveItemAsync("authToken");
            _authenticationStateProvider.LoggedOut();
        }

        [AllowAnonymous]
        [HttpPost("register")]
        public async Task<bool> Register(RegistrationModel model)
        {
            var request = new HttpRequestMessage(HttpMethod.Post, Endpoints.RegisterEndpoint);
            request.Content = new StringContent(JsonConvert.SerializeObject(model), Encoding.UTF8, "application/json");

            var client = _client.CreateClient();
            HttpResponseMessage response = await client.SendAsync(request);

            return response.IsSuccessStatusCode;
        }
    }
}