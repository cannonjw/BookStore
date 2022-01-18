using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BookStore_UI.Static
{
    public static class Endpoints
    {
        public static string BaseUrl = "http://34.82.70.150:5003/";
        public static string AuthorsEndpoint = $"{BaseUrl}api/Authors/";
        public static string BooksEndpoint = $"{BaseUrl}api/Books/";
        public static string RegisterEndpoint = $"{BaseUrl}api/users/register";
        public static string LoginEndpoint = $"{BaseUrl}api/users/login";
    }
}