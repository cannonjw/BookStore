using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using BookStore_UI.Models;

namespace BookStore_UI.Contracts
{
    public interface IAuthenticationRepository
    {
        Task<bool> Register(RegistrationModel model);
        Task<bool> Login(LoginModel model);
        Task Logout();
    }
}