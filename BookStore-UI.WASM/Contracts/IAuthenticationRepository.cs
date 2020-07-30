using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using BookStore_UI.WASM.Models;

namespace BookStore_UI.WASM.Contracts
{
    public interface IAuthenticationRepository
    {
        Task<bool> Register(RegistrationModel model);
        Task<bool> Login(LoginModel model);
        Task Logout();
    }
}